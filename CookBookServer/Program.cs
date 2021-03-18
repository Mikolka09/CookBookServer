using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;
using System.Threading;

namespace CookBookServer
{
    class Program
    {
        private static IPAddress iP;
        private static IPEndPoint IPEnd;
        private static Socket server;
        private static Socket client;
        private static string adress = "127.0.0.1";
        private static int port = 1025;
        public static string products;
        public static ListCookBooks listRecipes;
        public static List<string> recipes;

        static void Main(string[] args)
        {
            iP = IPAddress.Parse(adress);
            IPEnd = new IPEndPoint(iP, port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            recipes = new List<string>();
            listRecipes = new ListCookBooks();

            Task.Run(() =>
            {
                try
                {
                    server.Bind(IPEnd);
                    server.Listen(10);
                    Console.WriteLine("Сервер ожидавет подключение...\n");
                    while (true)
                    {
                        client = server.Accept();
                        byte[] buff = new byte[4];
                        client.Receive(buff);
                        int length = BitConverter.ToInt32(buff, 0);
                        byte[] data = new byte[length];
                        client.Receive(data);
                        products = Encoding.Unicode.GetString(data);

                        Task task = Task.Run(() => SearchRecipe(products));
                        task.Wait();

                        if (recipes.Count > 0)
                        {
                            foreach (var item in recipes)
                            {
                                buff = Encoding.Unicode.GetBytes(item);
                                client.Send(BitConverter.GetBytes(buff.Length));
                                client.Send(buff);
                            }
                        }
                        else
                        {
                            buff = Encoding.Unicode.GetBytes("Нет подходящих рецептов");
                            client.Send(BitConverter.GetBytes(buff.Length));
                            client.Send(buff);
                        }
                        //int cnt = client.Available;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            });
            Console.ReadKey();
            Console.WriteLine("Сервер закрывается....");
            Console.ReadKey();
            server.Close();
        }

        private static void SearchRecipe(string products)
        {
            BinaryFormatter binary = new BinaryFormatter();
            string path = "bookrecipes.dat";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                listRecipes = (ListCookBooks)binary.Deserialize(fs);
            }
            string[] prods = products.Split();
            int countProd = prods.Length;
            int count = 0;
            foreach (var item in listRecipes.cookBooks)
            {
                for (int i = 0; i < prods.Length; i++)
                {
                    if (item.ListProducts.Contains(prods[i]))
                        count++;
                }
                if (count == countProd)
                {
                    recipes.Add(item.Recipe);
                    count = 0;
                }
            }

        }
    }

    [Serializable]
    public class CookBook
    {
        public int IdRecipe;
        public string NameRecipe;
        public List<string> ListProducts;
        public string Recipe;
    }

    [Serializable]
    public class ListCookBooks
    {
        public List<CookBook> cookBooks;
    }


}

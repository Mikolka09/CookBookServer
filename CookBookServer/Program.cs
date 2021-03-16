using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace CookBookServer
{
    class Program
    {
        private static IPAddress iP;
        private static IPEndPoint IPEnd;
        private static Socket server;
        private static Socket client;
        private static string adress = "127.0.0.1";
        private static int port = 8586;
        private static string products = "";
        private static List<CookBook> cookBooks;

        static void Main(string[] args)
        {
            iP = IPAddress.Parse(adress);
            IPEnd = new IPEndPoint(iP, port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            cookBooks = new List<CookBook>();
            server.Bind(IPEnd);
            server.Listen(10);

            Task.Run(() =>
            {
                try 
                { 
                while (true)
                {
                    client = server.Accept();
                    Task.Run(() =>
                    {
                        byte[] buff = new byte[4];
                        int bytesLenght = BitConverter.ToInt32(buff, 0);
                        byte[] data = new byte[bytesLenght];
                        client.Receive(data);
                        products = Encoding.Unicode.GetString(data);
                    });
                }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            });
            Console.ReadKey();
            Console.WriteLine("Сервер закрывается....");
            server.Close();
        }

        private static void SearchRecipe(string products)
        {

        }
    }

    public class CookBook
    {
        public int IdRecipe;
        public string NameRecipe;
        public List<string> ListProducts;
        public string Recipe;
    }
}

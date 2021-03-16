using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.IO;

namespace ListRecipes
{
    class Program
    {

        static void Main(string[] args)
        {
            ListCookBooks listRecipes = new ListCookBooks();
            listRecipes.cookBooks = new List<CookBook>();
            bool end = true;
            int i = 100;
            while (end)
            {
                Console.Clear();
                CookBook cook = new CookBook();
                Console.WriteLine("\tСоздание рецепта\n");
                Console.WriteLine();
                cook.IdRecipe = i;
                Console.Write("Введите название рецепта: ");
                cook.NameRecipe = Console.ReadLine();
                Console.Write("Введите перечень продуктов через пробел: ");
                string prods = Console.ReadLine();
                string[] prod = prods.Split();
                cook.ListProducts = new List<string>();
                foreach (var item in prod)
                {
                    cook.ListProducts.Add(item);
                }
                Console.WriteLine("Введите рецепт приготовления: ");
                cook.Recipe = Console.ReadLine();
                listRecipes.cookBooks.Add(cook);
                Console.WriteLine();
                Console.Write("Добавить еще один рецепт (Да-1, Нет-2): ");
                int var = Convert.ToInt32(Console.ReadLine());
                if (var == 1)
                {
                    end = true;
                    i++;
                }
                else
                    end = false;
            }
            Console.WriteLine();
            Console.WriteLine("Список рецептов создан!");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\tСохраняем книгу список рецептов в файл\n");
            Console.Write("Введите имя файла: ");
            string nameFile = Console.ReadLine() + ".dat";
            BinaryFormatter binary = new BinaryFormatter();
            using (FileStream fs = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                binary.Serialize(fs, listRecipes);
            }
            Console.WriteLine("\nСписок рецептов сохранен!");

            Console.ReadKey();
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

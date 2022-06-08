using System;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Linq;
using System.Text;
using System.IO;

namespace Classroom_wk1_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Maria T\source\repos\Classroom wk1 exercise1\Classroom wk1 exercise1\tiedosto.txt";

            Console.WriteLine("How many products will you be needing?");
            int productAmount = Convert.ToInt32(Console.ReadLine());
            int i = productAmount;
            string[] productArray = new string[productAmount];

            for (i = 0; i < productAmount; i++)
            {
                Console.WriteLine("Name the item:");
                productArray[i] = Console.ReadLine();
            }

            ShoppingListSync(path, productArray);

            async Task ShoppingListSync(string path, string [] productArray)
            {
                await System.IO.File.WriteAllLinesAsync(path, productArray);
            }


        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    internal class Exercice_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string userName = Console.ReadLine();
            DateTime now = DateTime.Now;
            Console.WriteLine($"Привет, {userName}, сегодня {now.ToString("D")}.");
            Console.ReadLine();
        }
    }
}

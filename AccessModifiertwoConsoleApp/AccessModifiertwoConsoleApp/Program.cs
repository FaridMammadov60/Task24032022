using AccessModifiertwoConsoleApp.Models;
using System;
using System.Text;

namespace AccessModifiertwoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Person adam = new Person("fer", 70)
            {
                Surname ="Məmmədov"
            };
            Console.WriteLine("Adamın məlumatları");           
            Console.WriteLine(adam);
            Console.WriteLine("-------------------------");

            Console.WriteLine("-------------------------");
            Student telebe = new Student("Həsən", 180, 99.90)
            {
                Surname = "Məmmədzadə"
            };
            Console.WriteLine("Tələbənin məlumatları");            
            Console.WriteLine(telebe);

        }
    }
}

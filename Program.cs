using System;

namespace konsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminiz Nedir:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}

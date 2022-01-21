// See https://aka.ms/new-console-template for more information
using System;

namespace console_proramlama
{


    class Program
    {
        public static void Main(String [] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}



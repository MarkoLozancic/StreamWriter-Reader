using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamPisac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Upisite prezime: ");
            string prezime = Console.ReadLine();

            StreamWriter sw = new StreamWriter(
                @"c:\prviDir\mojaDatoteka.txt");

            sw.WriteLine("Ime: {0}", ime);
            sw.WriteLine("Prezime: {0}", prezime);
            sw.Close();


            StreamReader sr = new StreamReader(@"c:\prviDir\mojaDatoteka.txt");
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.ReadKey();
        }
    }
}

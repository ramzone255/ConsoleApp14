using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"Lines.txt", Encoding.UTF8);
            Console.WriteLine(sr.ReadToEnd());
            string str = File.ReadLines("Lines.txt").First();
            str = string.Concat(str.Select(c => (char)(char.ToLower(c) ^ char.ToUpper(c) ^ c)));
            StreamWriter sw = new StreamWriter(@"Rezult.txt");
            sw.WriteLine(str);
            sw.Close();
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}

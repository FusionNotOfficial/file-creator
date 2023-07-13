using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = string.Empty;
            string path = string.Empty;
            Console.WriteLine("Enter file name: ");
            fileName = Console.ReadLine();
            path = "F:\\" + fileName + ".txt";
            Console.WriteLine("Enter some text here: ");
            string text = Console.ReadLine();
            File.WriteAllText(path, text);
        }
    }
}

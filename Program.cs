using System;
using System.IO;
using System.Linq;

namespace Laba_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            File.WriteAllText("input.txt", "5\n2\n9\n1\n8\n532\n23\n94\n15\n82\n");

            string[] lines = File.ReadAllLines("input.txt");

            var sortedLines = lines.OrderBy(line => int.Parse(line));

            File.WriteAllLines("output.txt", sortedLines);

            Console.WriteLine("Файл був відсортований та записаний у файл output.txt");
        }
    }
}

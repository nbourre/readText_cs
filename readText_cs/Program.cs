using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace readText_cs
{
    class Program
    {
        static string filename;
        static string input;
        static StreamReader file;

        static int nbTest;

        static void Main(string[] args)
        {
            filename = args[0];

            if (filename == string.Empty)
            {
                Console.WriteLine("Aucun fichier fourni" + Environment.NewLine);
                Environment.Exit(-1);
            }

            file = File.OpenText(filename);

            input = file.ReadToEnd();

            nbTest = int.Parse(file.ReadLine());

            // Do you things here!


            Console.Write(input);
            Console.ReadKey();

        }
    }
}

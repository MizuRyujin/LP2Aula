using System;
using System.IO;

namespace LerTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string ficheiro = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "newData.txt");

            using (StreamReader sr = new StreamReader(ficheiro))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

        }
    }
}

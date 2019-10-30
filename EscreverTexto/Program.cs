using System;
using System.IO;

namespace EscreverTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Olá porcos";

            int i = 33;

            float x = 20.5f;

            string ficheiro = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "newData.txt");

            StreamWriter sw = new StreamWriter(ficheiro);

            sw.WriteLine(s);
            sw.WriteLine(i);
            sw.WriteLine(x);

            sw.Close();
        }
    }
}

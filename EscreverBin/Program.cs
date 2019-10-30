using System;
using System.IO;

namespace EscreverBin
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
                "newBinData.txt");

            using (FileStream fs = new FileStream(
                ficheiro, FileMode.Create, FileAccess.Write))
            {
                using(BinaryWriter br = new BinaryWriter(fs))
                {
                    br.Write(s);
                    br.Write(i);
                    br.Write(x);
                }
            }
        }
    }
}

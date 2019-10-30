using System;
using System.IO;

namespace LerBin
{
    class Program
    {
        static void Main(string[] args)
        {
            string ficheiro = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "newBinData.txt");

            using (FileStream fs = new FileStream(
                ficheiro, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    string s = br.ReadString();
                    int i = br.ReadInt32();
                    float f = br.ReadSingle();

                    Console.WriteLine(i);
                    Console.WriteLine(s);
                    Console.WriteLine(f);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Read_Single_Column
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            var temp = File.ReadAllLines(@"C:\Users\strea\Desktop\temp.csv");
            List<MappedCSV> extracT = new List<MappedCSV>();
            List<string> lines = new List<string>();
            foreach (var line in temp)
            {
                var delimitedLine = line.Split(',');
                extracT.Add(new MappedCSV(delimitedLine[1], delimitedLine[5]));
                
                lines.Add(delimitedLine[1] + "," + delimitedLine[5]);
                if(extracT.Count ==12)
                {

                    lines.ForEach(Console.WriteLine);
                    Console.ReadLine();
                }
                i++;
            }

        }
    }

    internal class MappedCSV
    {
        public string Third { get; set; }
        public string Fifth { get; set; }
        public MappedCSV(string third, string fifth)
        {
            Third = third;
            Fifth = fifth;
        }
    }
}

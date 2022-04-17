using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppfileRazbor3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("input.txt");
            StreamWriter streamWriter = new StreamWriter("output.txt");

            int countLines = int.Parse(streamReader.ReadLine());

            int sum = 0;
            for (int i = 0; i < countLines; i++)
            {
                int currentNumber = int.Parse(streamReader.ReadLine());
                sum += currentNumber;
            }

            streamWriter.WriteLine(sum);


            streamReader.Close();
            streamWriter.Close();
        }
    }
}

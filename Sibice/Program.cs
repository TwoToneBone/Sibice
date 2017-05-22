using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');            
            int n = int.Parse(inputs[0]);
            int width = int.Parse(inputs[1]);
            int height = int.Parse(inputs[2]);
            string[] outputs = new string[n];
            double diagonal = Math.Sqrt((width * width) + (height * height));

            for (int i = 0; i < n; i++)
            {
                int length = int.Parse(Console.ReadLine());
                if (length <= diagonal)
                {
                    outputs[i] = "DA";
                }
                else
                {
                    outputs[i] = "NE";
                }
            }

            foreach (string s in outputs)
            {
                Console.WriteLine(s);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMoreTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            string input = string.Empty;
            while (!input.Equals("stop"))
            {
                str  = $"{input} {Console.ReadLine()}";
            } 
            Console.WriteLine(str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, path;
            str = string.Empty;
            path = string.Empty;
            if (ConfigurationManager.AppSettings["config"].Equals("console"))
            { 
                str = Console.ReadLine();
            }

            if (ConfigurationManager.AppSettings["config"].Equals("txt"))
            { 
                path = Console.ReadLine();
                if (File.Exists(path))
                {
                    str = File.ReadAllText(path);
                }
            }
		str = str.ToLower();
            str = $"{DateTime.Now.ToString("dd:mm:yy HH:mm:ss:fff")} {str}";
            
            str = str.Replace(".", "." + System.Environment.NewLine + DateTime.Now.ToString("dd:mm:yy HH:mm:ss:fff"));
            str = str.Replace("?", "?" + System.Environment.NewLine + DateTime.Now.ToString("dd:mm:yy HH:mm:ss:fff"));
            str = str.Replace("!", "!" + System.Environment.NewLine + DateTime.Now.ToString("dd:mm:yy HH:mm:ss:fff"));
            str = str.Remove(str.TrimEnd().LastIndexOf(Environment.NewLine));
            Console.WriteLine(str);
          
           
    }

    }
}

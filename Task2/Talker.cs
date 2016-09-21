using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace Task2
{
    class Talker
    {
        private string str;
        public string Str { get; set; }
        private string path;
        public string Path { get; set; }
        private string config;
        public string Config { get; set; }
        private const string EntStr = "Enter String:";
        private const string EntPath = "Enter Path:";
        private const string WrongPath = "Wrong Path:";
        private const string NewStr = "New String:";
        private const string ConfigSetting = "config";
        private const string ConfigParamConsole = "console";
        private const string ConfigParamFile = "file";
        Creater crtr = new Creater();

        public void EnterString()
        {
            this.Str = string.Empty;
            this.Path = string.Empty;
            this.Config = ConfigurationManager.AppSettings[ConfigSetting];
            switch (this.Config)
            {
                case ConfigParamConsole:
                    Console.WriteLine(EntStr);
                    this.Str = Console.ReadLine();
                    break;
                case ConfigParamFile:
                    Console.WriteLine(EntPath);
                    this.Path = Console.ReadLine();
                    while (!File.Exists(this.Path))
                    {
                        Console.WriteLine(WrongPath);
                        this.Path = Console.ReadLine();
                    }
                    this.Str = File.ReadAllText(this.Path);
                    break;
            }

            this.Str = crtr.CreateNewString(this.Str);
            Console.WriteLine(NewStr);
            Console.WriteLine(this.Str);
        }
    }
}

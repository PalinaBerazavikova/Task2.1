using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Creater
    {
        private const string DateFormat = "dd:mm:yy HH:mm:ss:fff";
        private const string Quest = "?";
        private const string Dot = ".";
        private const string Exclam = "!";

        public string CreateNewString(string str)
        {
            str = str.ToLower();
            str = $"{DateTime.Now.ToString(DateFormat)} {str}";
            str = MadeNewString(str, Dot);
            str = MadeNewString(str, Quest);
            str = MadeNewString(str, Exclam);
            if (str.LastIndexOf(Environment.NewLine) > 0)
            {
                str = str.Remove(str.TrimEnd().LastIndexOf(Environment.NewLine));
            }
            return str;
        }

        public string MadeNewString(string str, string symb)
        {
            return str.Replace(symb, $"{symb}{ System.Environment.NewLine}{DateTime.Now.ToString(DateFormat)}");
        }
    }
}

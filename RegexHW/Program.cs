using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexProgram regexP = new RegexProgram();
            regexP.massage();
            regexP.CiscoToWin();
            Console.WriteLine("Преобразование...");
            regexP.massage();
        }
    }
}

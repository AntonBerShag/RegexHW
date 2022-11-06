using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexHW
{
    internal class RegexProgram
    {
        private string macAdressCisco = "901b.0e94.83a8";
        private string macAdressWin;

        public string CiscoToWin()
        {
            Regex regex = new Regex(@"[0-9a-z]{1,4}");
            MatchCollection matches = regex.Matches(macAdressCisco);
            foreach (Match match in matches)
            {
                macAdressWin += match.Value;
            }
            macAdressWin = macAdressWin.ToUpper();
            macAdressWin = Regex.Replace(macAdressWin, ".{2}", "$0-");
            macAdressWin = macAdressWin.TrimEnd('-');
            return macAdressWin;
        }
        public void massage()
        {
            Console.WriteLine("MAC address Cisco имеет вид: {0}", macAdressCisco);
            Console.WriteLine("MAC address Windows имеет вид: {0}", macAdressWin);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankomat bank = new Bankomat (1,2);
            bank.Start ();
            bank.SelectLanguage ();
           // bank.EnterPincode(1234);
            bank.SelectOperation ();

            Console.ReadLine ();
        }
    }
}
    
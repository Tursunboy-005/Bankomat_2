using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bankomat_2
{
    internal class Bankomat
    {
        public int Id { get; set; }
        public int Address { get; set; }

        public Bankomat(int id, int address) 
        {
            Id = id;
            Address = address;
        }
        public  void Start()
        {
            Console.WriteLine(" -*-*-*-*-*-*-*Welcome to Bankomat*-*-*-*-*-*- ");

        } 
        
        public void SelectLanguage()
        {
            Console.WriteLine("1.UZ");
            Console.WriteLine("2.RUS");
            Console.WriteLine("3.ENG");

            int n = int.Parse(Console.ReadLine());

            if(n == 1)
            {
                Console.WriteLine("Siz O'zbekchani tanladizngiz!");
            }else if(n == 2)
            {
                Console.WriteLine("Siz Ruschani tanladingiz!");
            }else if (n == 3)
            {
                Console.WriteLine("Siz Englizchani tanladingiz!");
            }
        }

        public bool EnterPincode(string pincode)
        {
            Console.Write("Enter a code : ");

            bool check = int.TryParse(pincode, out int n);

            n = 1234; 

            if(check && pincode.Length == 4) 
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            return check;
        }

        public void SelectOperation()
        {
            Console.WriteLine("1.Check Balance");
            Console.WriteLine("2.Change Pincode");
            Console.WriteLine("3.Withdraw money");
            Console.WriteLine();
            Console.Write("Enter option : ");
            int n = int.Parse(Console.ReadLine());

            const int sum = 10000000; 

            if(n == 1)
            {
                Console.WriteLine(sum);
            }else if (n == 2)
            {
                Console.Write("Enter a new pincode :");
                int code = int.Parse(Console.ReadLine());

                if(code.ToString().Length == 4 )
                {
                    Console.WriteLine("Pincode well done");            
                }
                else
                {
                    Console.WriteLine("Pincode worse done");
                }
            }else if(n == 3) 
            {
                Console.WriteLine("Enter withdraw money amount : ");
                int money = int.Parse(Console.ReadLine());
                if(money <= sum)
                {
                    Console.WriteLine($"Remaining amount{sum - money}");
                }else if(money >= sum) 
                {
                    Console.WriteLine("Fault summa");
                }
            }
        }
    }
}

using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace M10
{
    public class Program()
    {
        public static void Main(string[] args)
        {
            //var account = new BankAccount("Ali", 10000);
            //Console.WriteLine($"{account.Number} nomreli {account.Owner} adli istifadeci ucun {account.Balance} baslangic balansi acildi.");
            BankAccount account = null;


            int add = 0;
            bool isContinue = true;

            while (isContinue)
            {
                Console.WriteLine();

                Console.WriteLine("Zehmet olmasa seçiminizi edin: ");
                Console.WriteLine("0: Hesab elave etmek");
                Console.WriteLine("1: Balans elave etmek");
                Console.WriteLine("2: Pul çekmek");
                Console.WriteLine("3: Hesab melumatları");
                Console.WriteLine("4: Programdan çıxış");
                Console.WriteLine();

                int operation = int.Parse(Console.ReadLine());

                if (operation == 4) { break; }
                if ( operation !=0 && account == null) { Console.WriteLine("hesab yarat"); continue; }
                

                switch (operation)
                {

                    case 0:
                        Console.Write("Adinizi daxil edin: ");
                        string name = Console.ReadLine();
                        Console.Write("Balansi daxil edin: ");
                        decimal init = decimal.Parse(Console.ReadLine());
                        account = new BankAccount(name, init);
                        Console.WriteLine("Hesab elave edildi!");
                        break;

                    case 1:
                        Console.WriteLine("Elave etmek istediyiniz meblegi daxil edin: ");
                        add = Convert.ToInt32(Console.ReadLine());
                        account.MakeDeposit(add, DateTime.Now, "Hesaba pul elave edildi");
                        Console.WriteLine(add + " manat hesabiniza elave edildi");
                        Console.WriteLine(account.GetAccountHistory());

                        break;

                    case 2:
                        Console.WriteLine("Cixarmaq istediyiniz meblegi daxil edin: ");
                        add = Convert.ToInt32(Console.ReadLine());
                        account.MakeWithdrawal(add, DateTime.Now, "Hesabdan pul cixarishi");
                        Console.WriteLine(add + "manat hesabinizdan cixarildi");

                        Console.WriteLine(account.GetAccountHistory());

                        break;

                    case 3:

                        Console.WriteLine("Hesab melumatlariniz: ");
                        Console.WriteLine(account.GetAccountHistory());
                        break;

                    case 4:

                        isContinue = false;
                        break;
                    default:

                        Console.WriteLine("Zehmet olmasa 1/2/3/4 reqemlerinden birini secin: ");
                        add = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
        }
            //// Test daxil edilen mebleglerin musbet olmasi ile bagli.
            //BankAccount invalidAccount;
            //try
            //{
            //    invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //    return;
            //}

            //// Test menfi balans ucun.
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            //Console.WriteLine(account.GetAccountHistory());
        }
    }
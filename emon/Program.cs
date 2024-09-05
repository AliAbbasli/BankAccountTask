using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bir işlem seçin (1: Para Ekle, 2: Çıkış): ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Elave etmek istediyiniz meblegi daxil edin: ");
                    int add = Convert.ToInt32(Console.ReadLine());
                    account.MakeDeposit(add, DateTime.Now, "Hesaba pul elave edildi");
                    Console.WriteLine(add + " manat hesabiniza elave edildi");

                    Console.WriteLine(account.GetAccountHistory());
                    break;

                case 2:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return; // Döngüden çıkmak için return kullanabilirsiniz.

                default:
                    Console.WriteLine("Zehmet olmasa 1/2 reqemlerinden birini secin: ");
                    break;
            }
        }

    }

}
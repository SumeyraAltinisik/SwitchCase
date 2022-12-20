using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir harf giriniz:");
            string harf = Console.ReadLine();

            switch (harf)
            {
                case "a":
                    Console.WriteLine("Ahmet, Ali, Ayşe, Aslı, Aydın");
                    break;
                case "b":
                    Console.WriteLine("Betül, Büşra, Barış, Berra, Burak");
                    break;
                case "c":
                    Console.WriteLine("Ceyda, Cemre, Ceren, Cenk, Cem");
                    break;
                case "d":
                    Console.WriteLine("Deniz, Derya, Damla, Dilek, Dinçer");
                    break;
                default:
                    Console.WriteLine("Bu karakterle uyuşan isim bulunamadı");
                    break;
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ulke birinciUlke = new ulke();
            birinciUlke.UlkeAdi = "Türkiye";
            birinciUlke.Baskent = "Ankara";
            birinciUlke.ParaBirimi = "TL";
            birinciUlke.Nufus = 70000000;
            birinciUlke.Yazdir();



            ulke ikinciUlke = new ulke();
            ikinciUlke.UlkeAdi = "Almanya";
            ikinciUlke.Baskent = "Berlin";
            ikinciUlke.Nufus = 80000000;
            ikinciUlke.ParaBirimi = "Euro";
            ikinciUlke.Yazdir();

            Console.ReadKey();

        }
    }
}

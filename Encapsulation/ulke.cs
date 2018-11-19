using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// https://www.ahmetcansever.com/programlama/c-class-encapsulation-kapsulleme/ Teşekkürler
/// </summary>
namespace Encapsulation
{
    class ulke
    {
       private string ulkeAdi; 

        public string UlkeAdi
        {
            get
            {
                return ulkeAdi;
            }
            set
            {
                ulkeAdi = value;
            }
        }

       private string baskent;
        public string Baskent
        {
            get
            {
                return baskent;
            }
            set
            {
                baskent = value;
            }
        }

        private int nufus;

        public int Nufus
        {
            get
            {
                return nufus;
            }
            set
            {
                nufus = value;
            }
        }

       private string paraBirimi;
        public string ParaBirimi
        {
            get
            {
                return paraBirimi;
            }
            set
            {
                paraBirimi = value;
            }
        }

        public void Yazdir()
        {
            Console.WriteLine("Ülke adı: " + ulkeAdi);
            Console.WriteLine("Başkenti: " + baskent);
            Console.WriteLine("Nüfusu: " + nufus);
            Console.WriteLine("Para Birimi: " + paraBirimi);
            Console.WriteLine("////////////////////////////");

        }

    }
}

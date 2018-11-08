using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Kapsülleme (Encapsulation) kavramı bir nesnenin bazı özellik ve işlevlerini başka sınıflardan ve nesnelerden saklamaktır.
/// Private erişim belirteci sayesinde bu şekilde tanımlanan bir field’ i başka sınıflardan gizlemiş oluruz.
/// Ayrıca bu field başka sınıflarda kullanılamaz.
/// Kapsülleme (Encapsulation) sayesinde nesneler bilinçsiz kullanımdan korunmuş olur.
/// Fakat bazı durumlarda private field’ lara erişmemiz ve özelliklerini kullanmamız gerekebilir. 
/// Bu durumda Property kavramı devreye girer. Property bir field’ in değerini geri döndürmeye (Get) ve değerini ayarlamaya (Set) olanak sağlar.
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

# Encapsulation 

**Kapsülleme (Encapsulation)** : Bir nesnenin bazı özellik ve işlevlerinin dışarıya kapalı olması ve bu sınıfın her türlü veri iletişiminin kontrol altındaki metodlar ile yapılmasıdır.Kapsülleme (Encapsulation) sayesinde nesneler bilinçsiz kullanımdan korunmuş olur.  


Class içinde tanımlanan değişkenlere **field** denir.Private erişim belirteci sayesinde tanımlanan bir field’ i başka sınıflardan gizlemiş oluruz.


Bazı durumlarda private field’lara erişmemiz ve özelliklerini kullanmamız gerekebilir.
Private tanımlanmış fieldları "public" tanımlanmış bir aracı tarafından kontrol edebileceğimiz nesnelere **Property** denir.


> Property: Bir field’ in değerini geri döndürmeye (Get) ve değerini ayarlamaya (Set) olanak sağlar.


Örnek:
------

```c# 
class Kisi
    {
      //field'larımız
        string _ad;
        string _soyad;
        private int _yas;
        

      //property'lerimiz
        public string Ad
        {
            get { return this._ad; }
            set { this._ad = value; }
        }
        public string Soyad
        {
            get { return this._soyad; }
            set { this._soyad = value; }
        }
  ```


Kişinin yaşı eğer - değer girilirse 0 yazılması için kısıt girildi.
     
     
      
```c#  
    
     public int Yas
        {
            get { return this._yas; }
            set
            {
               
                if (value < 0)
                {
                    this._yas = 0;
                }
                else
                {
                    this._yas = value;
                }
            }
        }

 ```
 
 
 
Görüldüğü gibi her "field" için bir "property" tanımladık ve erişim belirleyicilerini "public" olarak belirttik.
 
 
**Bir de kısa "property" kullanımı vardır.
Fakat bu kullanımda "field" tanımlanmaz.Ve "get", "set" metodlarının ikisinin de bulunması gerekir.
Bu "property" nesnesini kullanmanın kısa yolu ise "prop" yazıp iki kere "tab" tuşuna basmaktır. 
Bu bir "snippet" 'tır. "Snippet" 'lar kod yazarken kolaylık olması açısından önceden tanımlanmış
ve bu tanımlara belirli kodlar atanmış kısaltmalardır. Aşağıda Ülke nesnesi kısa property şeklinde yazılmıştır.**



```c#
     public string Ulke
        {
            get; set;
        }
        
```


Metodumuz


```c#
  
  public void Yazdir()
        {
            Console.WriteLine("adı: " + _ad);
            Console.WriteLine("soyadı: " + _soyad);
            //get kullandığımız için okuma yapıyor 
            Console.WriteLine("yas: " + _yas);
            Console.WriteLine("ulke: " + Ulke);
            Console.WriteLine("////////////////////////////");

        }
    }
}
        
```


Programımız


```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi();
            kisi1.Ad = "Ayşe";
            //set kullandığımız içinde atama yapabiliyoruz
            kisi1.Soyad = "Eryılmaz";
            kisi1.Yas = -3;
            kisi1.Ulke = "Türkiye";
            kisi1.Yazdir();

            

            Console.ReadKey();

        }
    }
}

```

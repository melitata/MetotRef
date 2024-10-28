using System;
namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        { //erisim_belirteci geri_donus_tipi metot_adi(parametre_listesi/arguman)
          // {
          //     //komutlar 
          //return donus_degeri;
          // }
          //Erişim belirteci: Metoda kimlerin erişebileceğini belirtir. Public, private, protected, internal, protected internal
          //Geri dönüş tipi: Metodun döndüreceği değerin tipini belirtir. void, int, string, double, bool
          //Metot adı: Metodun ismi
          //Parametre listesi: Metoda gönderilecek parametrelerin tanımlandığı kısımdır.
          //Metot içeriği: Metodun yapacağı işlemlerin tanımlandığı kısımdır.
          //Metotlar, programlama dillerinde tekrar tekrar kullanılabilen kod bloklarıdır. Metotlar, kodun daha okunabilir ve düzenli olmasını sağlar. Ayrıca kodun tekrar tekrar yazılmasını engeller.
          //Metotlar, C# programlama dilinde aşağıdaki şekilde tanımlanır:
          //Erişim_belirteci geri_donus_tipi metot_adi(parametre_listesi),


          int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));


        }
        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }

    }

    class Metotlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }

    }
}
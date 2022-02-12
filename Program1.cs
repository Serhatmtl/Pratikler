using System;

namespace Metotlar
{


    class Program
    {
        public static void Main(String[] args)
        {

            // Erişim_Belirteci Geri_Dönüş_Tipi Metod_Adi (Parametre_Listesi / Argüman)
            //{
                //komutlar;
                //return;
            //}

            int a = 3;
            int b = 5;

            Consol.Writeline(a+b)

            int sonuc = Topla(a,b);
            Consol.Writeline(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttirveTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));

        }


        static int Topla(ref int Deger1, ref int Deger2)
        {
            return (Deger1 + Deger2)
        }
        
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Consol.Writeline(veri);
        }

        public int ArttirveTopla(int Deger1, int Deger2)
        {
            Deger1 += 1;
            Deger2 += 2;
            return Deger1 + Deger2;
        }
    }

}


using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //değer tutucu - kategoriEtiketi, alias yani takma isim
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            if(sistemeGirişYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu ");
            }
            else
            {
                Console.WriteLine("Giriş yap ! ");
            }



        }
    }
}

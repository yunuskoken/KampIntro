using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java",
                "C#"};
            
            for (int i = 1; kurslar.Length < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("For Bitti !");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

  

            Console.WriteLine("Sayfa Sonu = footer");
        }
    }
}

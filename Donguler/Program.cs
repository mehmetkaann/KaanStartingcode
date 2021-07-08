using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // bunu yapma!
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kapmı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            // print print Print ..


            //array -dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kapmı",
             "Programlamaya başlangıç için temel kurs", "java", 
            "Python"};


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            // for yernine bu döngü daha kolay ve mantıklı dizi için
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}

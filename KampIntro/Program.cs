using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği - 2bölüm 22dk
            //Do not repeat yourself

            string KategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000000; // 8 sıfırlı sayılar max
            double faizOrani = 1.45;  //noktalı sayılar
            bool sistemeGirisYapmisMi = true; // evet hayır - şart
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(KategoriEtiketi);

        }
    }
}
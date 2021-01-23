using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			string kategoriEtiketi = "Kategoriler";
			int ogrenciSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmismi = false;
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

            if (sistemeGirisYapmismi == true)
            {
				Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
				Console.WriteLine("Giriş yap butonu");
            }

			Console.WriteLine(kategoriEtiketi);

			
		}
	}
}

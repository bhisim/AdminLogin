using System;

namespace AdminLogin
{
    class Program
    {
        static void Main(string[] args)
        {/* Bahar Merdamert max 3 kez denenince login olabilen uygulama */
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Lütfen kullanıcı adınızı giriniz...");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Lütfen şifrenizi giriniz...");
                string sifre = Console.ReadLine();

                if (kullaniciAdi == "admin" && sifre == "123")
                {
                    Console.WriteLine("Hoşgeldin admin...");
                    break;
                }
                else
                    Console.WriteLine("Şifrenizi veya kullanıcı adınızı yanlış girdiniz...");
                    Console.WriteLine("***************************************************");

            }
            Console.ReadKey();
        }
    }
}

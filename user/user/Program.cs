using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user
{
    internal class Program
    {
        class User
        {
            private string adSoyad; 
            private int yas; 
            public string Email { get; set; } 

            public string GetAdSoyad()
            {
                return adSoyad;
            }

            public void SetAdSoyad(string value)
            {
                adSoyad = value;
            }

            public int GetYas()
            {
                return yas;
            }

            public void SetYas(int value)
            {
                if (value >= 0) 
                    yas = value;
                else
                    Console.WriteLine("Yaş negatif olamaz!");
            }

            public void BilgileriGoster()
            {
                Console.WriteLine($"Ad Soyad: {adSoyad}, Yaş: {yas}, Email: {Email}");
            }
        }

        class Progr
        {
            static void Main()
            {
                User kullanici = new User();

                kullanici.SetAdSoyad("Yekta Tufan");
                kullanici.SetYas(27);
                kullanici.Email = "yekta.tufan@example.com";


                kullanici.BilgileriGoster();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.dizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar ={ 5, 2, 20, 360, 390, 390, 390, 256, 256, 256, 45, 45, 74, 85, 55, 0, 0, 0, 0, 0, 3, 5};
            int adet = 0;
            int sayi;
            Console.WriteLine("Lütfen bir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<sayilar.Length;i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }
            if (adet==0)
            {
                Console.WriteLine("Girilen değer dizide bulunamadı...");
            }
            else
            {
                Console.WriteLine("Girilen değer dizide bulundu...");
                Console.WriteLine("Dizideki toplam adet:" + adet);
            }
            Console.ReadLine();
        }
    }
}

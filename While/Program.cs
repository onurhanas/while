using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
        int sayac=1;
        int toplam =0;
          while(sayac<=sayi){
            toplam+=sayac;
            sayac++;

          }
          Console.WriteLine(toplam/sayi);
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
        }
      
    }
}
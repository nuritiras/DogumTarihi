using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogumTarihi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YasSinifi yasSinifi = new YasSinifi();

            DateTime Tarih = DateTime.Now;
            Console.WriteLine("Yaş="+ yasSinifi.Yas(1976));

            var date1 = new DateTime(1976, 01, 01);
            Console.Write("Gün Farkı="+ yasSinifi.Yas(date1).Days);

            Console.ReadLine();
        }
    }
    class YasSinifi
    {
        public int Yas(int dogum_yili)
        {
            DateTime simdi = DateTime.Now;
            return simdi.Year - dogum_yili;
        }

        public TimeSpan Yas(DateTime dogum_yili)
        {
            DateTime simdi = DateTime.Now;
            TimeSpan GunFarki = simdi-dogum_yili;
            return GunFarki;
        }
    }
}

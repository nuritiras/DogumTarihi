using System;

namespace DogumTarihi
{
    internal class YasSinifiBase
    {
        public int Yas(int dogum_yili)
        {
            DateTime yil;
            yil = DateTime.Now;
            return yil.Date.Year - dogum_yili; ;
        }
    }
}
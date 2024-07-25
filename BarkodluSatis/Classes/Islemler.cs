using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.Classes
{
    static class Islemler
    {
        public static double DoubleYap(string deger)
        {
            double sonuc = 0;
            double.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out sonuc);
            return Math.Round(sonuc, 2);
        }
    }
}

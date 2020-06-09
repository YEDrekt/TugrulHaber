using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugrulHaber
{
    public static class Veritabani
    {
        private static List<Haber> _haberler = new List<Haber>();

        public static void HaberEkle(Haber haber)
        {
            _haberler.Add(haber);
        }

        public static void HaberSil(Haber haber)
        {
            _haberler.Remove(haber);
        }

        public static Haber[] Haberler()
        {
            return _haberler.ToArray();
        }

        public static Haber[] Haberler(string tur)
        {
            if (tur == "")
            {
                return _haberler.ToArray();
            }
            else
            {
                return _haberler.Where(c => c.Tur() == tur).ToArray();
            }
        }

        public static string[] Turler()
        {
            return new string[3] { "Gündem", "Spor", "Dünya" };
            //return _haberler.Select(c => c.Tur()).Distinct().ToArray();
        }
    }
}

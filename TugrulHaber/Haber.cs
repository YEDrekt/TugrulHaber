using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugrulHaber
{
    public class Haber
    {
        private string _yazar;
        private string _baslik;
        private string _tur;

        private string _icerik;
        
        private DateTime _girisTarih;
        

        public Haber(string yazar, string baslik, string tur)
        {
            _yazar = yazar;
            _baslik = baslik;
            _tur = tur;
        }

        public Haber(string yazar, string baslik, string tur, string icerik)
        {
            _yazar = yazar;
            _baslik = baslik;
            _tur = tur;
            _icerik = icerik;
            Yayinla();
        }

        public string Baslik()
        {
            return _baslik;
        }

        public string Tur()
        {
            return _tur;
        }

        public string Icerik()
        {
            return _icerik;
        }

        public string Yazar()
        {
            return _yazar;
        }

        public DateTime GirisTarih()
        {
            return _girisTarih;
        }

        public void Yayinla()
        {
            _girisTarih = DateTime.Now;
            Veritabani.HaberEkle(this);
        }
    }
}

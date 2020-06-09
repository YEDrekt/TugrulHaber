using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TugrulHaber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _gecerliTur = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        
        public void HaberlerGuncelle()
        {
            if (_gecerliTur == "")
            {
                lsbxHaberler.ItemsSource = Veritabani.Haberler().Select(c => c.Baslik());
            }
            else
            {
                lsbxHaberler.ItemsSource = Veritabani.Haberler().Where(c => c.Tur() == _gecerliTur).Select(c => c.Baslik());
            }
        }

        private void btnTurHepsi_Click(object sender, RoutedEventArgs e)
        {
            _gecerliTur = "";
            HaberlerGuncelle();
        }

        private void btnTurGundem_Click(object sender, RoutedEventArgs e)
        {
            _gecerliTur = "Gündem";
            HaberlerGuncelle();
        }

        private void btnTurSpor_Click(object sender, RoutedEventArgs e)
        {
            _gecerliTur = "Spor";
            HaberlerGuncelle();
        }

        private void btnTurDunya_Click(object sender, RoutedEventArgs e)
        {
            _gecerliTur = "Dünya";
            HaberlerGuncelle();
        }

        private void btnHaberEkle_Click(object sender, RoutedEventArgs e)
        {
            TaslakWindow taslakWindow = new TaslakWindow(this);
            taslakWindow.Show();
        }

        private void btnOku_Click(object sender, RoutedEventArgs e)
        {
            if (lsbxHaberler.SelectedIndex > -1)
            {
                HaberWindow haberWindow = new HaberWindow(Veritabani.Haberler(_gecerliTur)[lsbxHaberler.SelectedIndex]);
                haberWindow.Show();
            }
        }

        private void btnDuzenle_Click(object sender, RoutedEventArgs e)
        {
            if (lsbxHaberler.SelectedIndex > -1)
            {
                TaslakWindow taslakWindow = new TaslakWindow(this, Veritabani.Haberler(_gecerliTur)[lsbxHaberler.SelectedIndex]);
                taslakWindow.Show();
            }
        }

        private void btnSil_Click(object sender, RoutedEventArgs e)
        {
            if (lsbxHaberler.SelectedIndex > -1)
            {
                Veritabani.HaberSil(Veritabani.Haberler(_gecerliTur)[lsbxHaberler.SelectedIndex]);
                HaberlerGuncelle();
            }
        }
    }
}

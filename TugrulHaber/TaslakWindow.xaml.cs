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
using System.Windows.Shapes;

namespace TugrulHaber
{
    /// <summary>
    /// Interaction logic for TaslakWindow.xaml
    /// </summary>
    public partial class TaslakWindow : Window
    {
        private MainWindow _mainWindow;
        private Haber _haber;

        public TaslakWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        public TaslakWindow(MainWindow mainWindow, Haber haber)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _haber = haber;
            tbxYazarIsim.Text = haber.Yazar();
            tbxHaberBaslik.Text = haber.Baslik();
            tbxHaberIcerik.Text = haber.Icerik();
            cmbxHaberTur.SelectedItem = haber.Tur();
        }

        private void btnYayinla_Click(object sender, RoutedEventArgs e)
        {
            if (tbxYazarIsim.Text != "" && tbxHaberBaslik.Text != "" && cmbxHaberTur.SelectedIndex > -1 && tbxHaberBaslik.Text != "" && tbxHaberIcerik.Text != "")
            {
                if (_haber == null)
                {
                    new Haber(tbxYazarIsim.Text, tbxHaberBaslik.Text, cmbxHaberTur.SelectedItem.ToString(), tbxHaberIcerik.Text);
                }
                else
                {
                    Veritabani.HaberSil(_haber);
                    new Haber(tbxYazarIsim.Text, tbxHaberBaslik.Text, cmbxHaberTur.SelectedItem.ToString(), tbxHaberIcerik.Text);
                }
                _mainWindow.HaberlerGuncelle();
                this.Close();
            }
        }

        private void windowTaslak_Loaded(object sender, RoutedEventArgs e)
        {
            cmbxHaberTur.ItemsSource = Veritabani.Turler();
        }
    }
}

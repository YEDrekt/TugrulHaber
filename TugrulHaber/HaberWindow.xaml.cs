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
    /// Interaction logic for HaberWindow.xaml
    /// </summary>
    public partial class HaberWindow : Window
    {
        private Haber _haber;
        public HaberWindow(Haber haber)
        {
            _haber = haber;
            InitializeComponent();
        }

        private void windowHaber_Loaded(object sender, RoutedEventArgs e)
        {
            tblkBaslik.Text = _haber.Baslik();
            lblTur.Content = _haber.Tur();
            lblYazar.Content = _haber.Yazar();
            lblGirisTarih.Content = _haber.GirisTarih();
            tblkIcerik.Text = _haber.Icerik();
        }
    }
}

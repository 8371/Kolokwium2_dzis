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

namespace Kolokwium2_dzis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Podroz podroz_cala = new Podroz();
        public MainWindow()
        {
            InitializeComponent();
            data_label1.Content = podroz_cala.ZwrocDate();
        }
        public void refresh_podroze()
        {
            podroz_label.Content = "";
            podroz_label.Content = podroz_cala;
        }
        public void ustawDate()
        {
            data_label1.Content = podroz_cala.ZwrocDate();
            refresh_podroze();
        }

        private void dodaj_autobus_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ilosc_label.Text))
                MessageBox.Show("Puste pole ilość miejsc.");
            else
            {
                int ilosc_miejsc = Convert.ToInt32(ilosc_label.Text);
                podroz_cala.DodajAutobus(ilosc_miejsc);
                refresh_podroze();
                MessageBox.Show("Dodaje AUTOBUS");
            }
        }

        private void dodaj_pociag_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ilosc_label.Text))
                MessageBox.Show("Puste pole ilość miejsc.");
            else
            {
                if (string.IsNullOrEmpty(dlugosc_label.Text))
                {
                    MessageBox.Show("Dla POCIAG podaj dlugosc trasy.");

                }
                else
                {
                    int dlugosc_trasy = Convert.ToInt32(dlugosc_label.Text);
                    int ilosc_miejsc = Convert.ToInt32(ilosc_label.Text);
                    podroz_cala.DodajPociag(ilosc_miejsc, dlugosc_trasy);
                    refresh_podroze();
                    MessageBox.Show("Dodaje POCIAG");
                }
            }
        }

        private void usun_ostatni_Click(object sender, RoutedEventArgs e)
        {
            if (podroz_cala.get_planpodrozyLEN() > 0)
            {
                podroz_cala.UsunOstatni();
                refresh_podroze();
                MessageBox.Show("Usuwam ostatni");
            }
            else
                MessageBox.Show("Pusty plan podróży");
            
        }

        private void wyczysc_btn_Click(object sender, RoutedEventArgs e)
        {
            podroz_cala.Wyczysc();
            refresh_podroze();
            MessageBox.Show("Lista podrozy wyczyszczona.");
        }

        private void ustaw_datę_btn_Click(object sender, RoutedEventArgs e)
        {
            podroz_cala.UstawDate(Convert.ToDateTime(data_label.Text));
            ustawDate();
            MessageBox.Show("Zaktualizowałem datę.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDateTime(data_label.Text) == podroz_cala.ZwrocDate())
                MessageBox.Show("Podana data jest dostępna.");
            else
                MessageBox.Show("Brak dostępnej daty.");
        }
    }
}

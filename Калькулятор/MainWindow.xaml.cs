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

namespace Калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtRabDay.Text = "";
            txtPremiya.Text = "";
            txtOtrbDay.Text = "";
            txtOklad.Text = "";
        }

        private void BtnRaschet_Click(object sender, RoutedEventArgs e)
        {
            double PlnZP=0;
            double NDFL;
            double ZPRuki;
            if(CmbRaionKof.SelectedIndex == 0)
            {
                PlnZP = Convert.ToDouble(txtOklad.Text) * 12 * (Convert.ToDouble(txtOtrbDay.Text) / Convert.ToDouble(txtRabDay.Text)) + Convert.ToDouble(txtPremiya.Text);
            }
            if (CmbRaionKof.SelectedIndex == 1)
            {
                PlnZP = Convert.ToDouble(txtOklad.Text) * 13 * (Convert.ToDouble(txtOtrbDay.Text) / Convert.ToDouble(txtRabDay.Text)) + Convert.ToDouble(txtPremiya.Text);
            }
            if (CmbRaionKof.SelectedIndex == 3)
            {
                PlnZP = Convert.ToDouble(txtOklad.Text) * 14 * (Convert.ToDouble(txtOtrbDay.Text) / Convert.ToDouble(txtRabDay.Text)) + Convert.ToDouble(txtPremiya.Text);
            }
            if (CmbRaionKof.SelectedIndex == 4)
            {
                PlnZP = Convert.ToDouble(txtOklad.Text) * 15 * (Convert.ToDouble(txtOtrbDay.Text) / Convert.ToDouble(txtRabDay.Text)) + Convert.ToDouble(txtPremiya.Text);
            }
            NDFL = PlnZP * 0.13;
            ZPRuki = PlnZP - NDFL;
            Window1 rascheti = new Window1();
            rascheti.lblPLzp.Content = Convert.ToString(PlnZP);
            rascheti.lblNDFL.Content = Convert.ToString(NDFL);
            rascheti.lblZpRuki.Content = Convert.ToString(ZPRuki);
            rascheti.Show();

        }

        private void txtOklad_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void txtPremiya_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void txtRabDay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void txtOtrbDay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}

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

namespace mutest2.Pages
{
    /// <summary>
    /// Interaction logic for BasicPage2.xaml
    /// </summary>
    public partial class BasicPage2 : UserControl
    {
        public BasicPage2()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        public void numbering_control()
        {
            numbering_window num = new numbering_window();
            num.Show();
        }



        private void Gingivitis(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void Periodontisis(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void Gross_Caries(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void Pocket(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void Retained_Deciduous(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void Missing(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void Orthodontics(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void B_D_R(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void Caries(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void Fracture(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void Cyst(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }

        private void Others(object sender, RoutedEventArgs e)
        {
            numbering_control();
        }
    }
}

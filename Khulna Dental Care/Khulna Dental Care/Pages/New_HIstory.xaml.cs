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
    /// Interaction logic for New_HIstory.xaml
    /// </summary>
    public partial class New_HIstory : UserControl
    {
        New_personal_info new_pinfo;

        public New_HIstory()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked_1(object sender, EventArgs e)
        {
            pregnency.Visibility = Visibility.Visible;
        }

       

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            pregnency.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            pregnency.Visibility = Visibility.Hidden;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void allergi_other_action(object sender, RoutedEventArgs e)
        { 
                allergi_other.Visibility = Visibility.Visible;   
        }

        private void illness_other_checkbox_action(object sender, RoutedEventArgs e)
        {
            illness_other.Visibility = Visibility.Visible;

        }
        private void illness_other_checkbox_uncheck(object sender, RoutedEventArgs e)
        {
            illness_other.Visibility = Visibility.Hidden;
            illness_other.Text = "";

        }

        private void allergi_other_checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            allergi_other.Visibility = Visibility.Hidden;
            allergi_other.Text = "";
        }

    }
}

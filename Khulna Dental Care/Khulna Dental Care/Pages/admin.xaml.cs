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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : UserControl
    {
        
        public admin()
        {
            InitializeComponent();
        }

        New_personal_info nwe_per_info;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (username.Text == "admin" && passbox.Password == "123456")
                admin_stack.Visibility = Visibility.Visible;
            else
            {
                admin_stack.Visibility = Visibility.Hidden;
               
            }

              

            //ModernDialog1.ShowMessage("sdf", "vfg", MessageBoxButton.OK);
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}

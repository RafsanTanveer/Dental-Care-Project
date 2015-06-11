using FirstFloor.ModernUI.Windows.Controls;
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
    /// Interaction logic for surface_window.xaml
    /// </summary>
    public partial class surface_window : ModernWindow
    {
        public surface_window()
        {
            InitializeComponent();
        }

        private void surface_ok_button(object sender, RoutedEventArgs e)
        {

        }

        private void surface_cancel_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}

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
    /// Interaction logic for cost.xaml
    /// </summary>
    /// 

    public partial class cost : UserControl
    {
        public cost()
        {
            InitializeComponent();
        }

      

        private void cost_login(object sender, RoutedEventArgs e)
        {
            cost_canvas.Visibility = Visibility.Visible;
            
        }
    }
}

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
    /// Interaction logic for new_prescription.xaml
    /// </summary>
    public partial class new_prescription : UserControl
    {
        public new_prescription()
        {
            InitializeComponent();
        }

        private void Print_Prescription(object sender, RoutedEventArgs e)
        {
            PrintDialog dialog = new PrintDialog();

            if (dialog.ShowDialog() != true) return;

            
        }

      
    }
}

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
using mutest2.Pages;

namespace mutest2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            /*SettingsAppearanceViewModel settings = new SettingsAppearanceViewModel();
            settings.SetThemeAndColor(ApplicationSettings.Default.SelectedThemeDisplayName,
                  ApplicationSettings.Default.SelectedThemeSource,
                  ApplicationSettings.Default.SelectedAccentColor,
                  ApplicationSettings.Default.SelectedFontSize);*/

        }
        
       

        private void Home_Loaded_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

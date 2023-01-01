using System.Windows;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BlApi.IBL bl = BlApi.BL_Factory.Get();

        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void OpenProductsWindow(object sender, RoutedEventArgs e)
        {
            new WndOrderList(bl).Show();
        }
    }
}

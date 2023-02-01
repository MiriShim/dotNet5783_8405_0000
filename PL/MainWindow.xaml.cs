using SimulatorLib;
using System.Windows;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Simulator  SimulatorOb ;
        BlApi.IBL bl = BlApi.BL_Factory.Get();

        public MainWindow()
        {
            InitializeComponent();
            SimulatorOb = SimulatorLib.Simulator.GetInstance(BlApi.BL_Factory.Get());
         }

        
        private void OpenProductsWindow(object sender, RoutedEventArgs e)
        {
            new WndOrderList(bl).Show();
        }

       
        private void StartSimulator(object sender, RoutedEventArgs e)
        {
            SimulatorOb.SetSimulatorOn();
            SimulatorWindow simulatorWindow = new();
            simulatorWindow.Show();
        }

        private void ViewSimulator(object sender, RoutedEventArgs e)
        {
            SimulatorWindow simulatorWindow = new();
            simulatorWindow.Show();
        }
    }
}

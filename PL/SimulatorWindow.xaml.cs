using BO;
using SimulatorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for SimulatorWindow.xaml
    /// </summary>
    public partial class SimulatorWindow : Window, INotifyPropertyChanged
    {
        Simulator SimulatorOb;
        private void NotifyPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public event PropertyChangedEventHandler? PropertyChanged;


        private Product currentProduct;

        public BO.Product CurrentProduct
        {
            get => currentProduct;
            set
            {
                if (value != currentProduct)
                {
                    currentProduct = value;
                    if (Dispatcher.Thread.IsAlive)
                    Dispatcher.Invoke(() => NotifyPropertyChanged($"current product is {this.Name}"));
                    
                }
            }
        }

        public SimulatorWindow()
        {
            InitializeComponent();
        }
        Timer timerForClock = new(1000);
         
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timerForClock.Elapsed += TimerForClock_Elapsed;
            timerForClock.Start();

            BackgroundWorker backgroundWorker = new BackgroundWorker();
              
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerAsync();

            SimulatorOb = Simulator.GetInstance(BlApi.BL_Factory.Get());
            SimulatorOb.RegisterProductSelected(productSelectedExe);
            SimulatorOb.RegisterSimulatorStoped(simulatorStoppedExe);
            SimulatorOb.RegisterStateChanged(StateChangedExe);
        }

        private void TimerForClock_Elapsed(object? sender, ElapsedEventArgs e)
        {
            if (Dispatcher.Thread.IsAlive)
                Dispatcher.BeginInvoke(() =>
                {
                tbClock.Text = DateTime.Now.ToString("h:mm:ss");
                    DO.ProductStatus currentStatus = currentProduct?.ProductStatus ?? DO.ProductStatus.State1; ;
                    pb.Value = (double )currentStatus ;
                     
                }
            );
        }

        private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            SimulatorOb = Simulator.GetInstance(BlApi.BL_Factory.Get());
            SimulatorOb.SetSimulatorOn();

            SimulatorOb.RegisterProductSelected(productSelectedExe);
            SimulatorOb.RegisterSimulatorStoped(simulatorStoppedExe);
            SimulatorOb.RegisterStateChanged(StateChangedExe);
        }

        private void simulatorStoppedExe()
        {
            timerForClock.Stop();
        
        }

        private void StateChangedExe(DO.ProductStatus prevState, DateTime startAt, DO.ProductStatus newState, DateTime endAt)
        {
            if (Dispatcher.Thread.IsAlive)
            Dispatcher.Invoke(() =>
            {
                tbPrevState  .Text = prevState.ToString();
                tbNewState.Text = newState.ToString();
                pb.Value = (int)newState;
                
            });
        }

        private void productSelectedExe(Product product)
        {
            CurrentProduct = product;
            Dispatcher.Invoke(() =>
            {
                tbProductName.Text = product?.Name;

                //tbPrevStatus.Text = product.ProductStatus.ToString();
            });
        }
    }
}

using AutoMapper;
using BO;
using PO;
using SimulatorLib;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace PL
{
    /// <summary>
    /// Interaction logic for SimulatorWindow.xaml
    /// </summary>
    public partial class SimulatorWindow : Window, INotifyPropertyChanged
    {  
       readonly  Stopwatch sw = new();
        Simulator SimulatorOb;
        BackgroundWorker backgroundWorker;
        private void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private PO.ProductInProgress currentProduct= new ProductInProgress() { Name = "???????", PrevStatus = ProductStatus.State2  };

        public PO.ProductInProgress CurrentProduct 
        {
            get => currentProduct;
            set
            {
                if (value != currentProduct)
                {
                    currentProduct = value;
                    if (Dispatcher.Thread.IsAlive)
                        //Dispatcher.Invoke(() => 
                        NotifyPropertyChanged("CurrentProduct");
                            //);

                }
            }
        }

        public SimulatorWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;

            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            
            backgroundWorker.RunWorkerAsync();

            SimulatorOb = Simulator.GetInstance(BlApi.BL_Factory.Get());
            
            SimulatorOb.RegisterProductSelected(productSelectedExe);
            SimulatorOb.RegisterSimulatorStoped(simulatorStoppedExe);
            SimulatorOb.RegisterStateChanged(StateChangedExe);

            //    הסימולטור כבר מופעל מחלון הראשי
            //             SimulatorOb.SetSimulatorOn();

        }

        private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            lblStooped.Visibility = Visibility.Visible;  
            //todo: do somthing to notify user that the simulator stopped safty;
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            tbClock.Text = DateTime.Now.ToString("h:mm:ss");
            progressBar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            sw.Start(); 
            while (!((BackgroundWorker)sender).CancellationPending )
            {
                if (!Dispatcher.Thread.IsAlive) { e.Cancel = true; break; }
                if (CurrentProduct == null) continue;
 
                if (CurrentProduct?.WillUpdateAt == 0)//בשביל הפעם הראשונה שעדין אין
                    continue;
                int minutes = CurrentProduct?.WillUpdateAt ?? 1;

                //חישוב אחוז הזמן שחלף
                double per = sw.ElapsedMilliseconds /1000.0 / (double)CurrentProduct?.WillUpdateAt *100   ; //(DateTime.Now - CurrentProduct.StartChangeAt).Minutes / minutes;
               
                ((BackgroundWorker)sender ).ReportProgress((int)per);
               
                Debug.WriteLine(sw.ElapsedMilliseconds);
                Debug.WriteLine(CurrentProduct?.WillUpdateAt);
                Debug.WriteLine(per);
                Debug.WriteLine((int)per);
                Debug.WriteLine("=====================");

                Thread.Sleep(1000);
            }


        }

        private void simulatorStoppedExe()
        {
            backgroundWorker.CancelAsync();

        }
        void fillUI()
        {
            //tbProductName.Text = CurrentProduct.Name;
            // tbNewState.Text = ((ProductStatus)((int)CurrentProduct.PrevStatus) + 1).ToString();
            //tbStartAt.Text = CurrentProduct.StartChangeAt .ToString("h:mm:ss");
            ////
            //tbProductName.Text = CurrentProduct?.Name;
            //tbWillUpdate.Text = currentProduct.WillUpdateAt.ToString() +" שניות" ;
            
         }


        private void StateChangedExe(BO.ProductStatus prevState, DateTime startAt, BO.ProductStatus newState, int durationInMinuts)
        {
            if (Dispatcher.Thread.IsAlive && currentProduct!=null)
                //Dispatcher.Invoke(() =>
                {
                    CurrentProduct.PrevStatus = prevState;
                    CurrentProduct.StartChangeAt = startAt;
                    CurrentProduct.WillUpdateAt = durationInMinuts;// CurrentProduct.StartChangeAt.AddMinutes(durationInMinuts) ;

                    fillUI();

                };//);
        }

        private void productSelectedExe(Product product, int willUpdateAt)
        {
            sw.Restart();

            MapperConfiguration conf = new MapperConfiguration(a => a.CreateMap<BO.Product, ProductInProgress>()
            .ForMember(m=>m.PrevStatus,a=>a.MapFrom(x=>x.ProductStatus))
            .ForMember(m=>m.WillUpdateAt ,a=>a.MapFrom(y=>willUpdateAt))
            .ReverseMap());
            Mapper mapper = new Mapper(conf);

            CurrentProduct = mapper.Map<ProductInProgress>(product);
            CurrentProduct.WillUpdateAt = willUpdateAt;

            CurrentProduct.PrevStatus = product.ProductStatus; ;
            CurrentProduct.StartChangeAt = DateTime.Now  ;
 
            //if (Thread.CurrentThread.IsAlive )
            //    if (Dispatcher.Thread.IsAlive)
            //Dispatcher.Invoke(() =>
            //{
            //    fillUI();
            //});
        }

        

        private void stop_Clicked(object sender, RoutedEventArgs e)
        {
            backgroundWorker.CancelAsync();
            SimulatorOb.SetSimulatorOff();
        }
    }
}

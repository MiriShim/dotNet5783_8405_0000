using PO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for WndOrderList.xaml
    /// </summary>
    public partial class WndOrderList : Window
    {
        BlApi.IBL bl ;
        ObservableCollection<ProductInProgress> ObservableProducts;
        List<BO.Category >  categories= Enum.GetValues<BO.Category>().ToList() ;
        public WndOrderList(BlApi.IBL bl)
        {
            InitializeComponent();
            this.bl = bl;
         }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // lvProducts.ItemsSource =  bl.Product .GetAll() ;
            cmbCategories.ItemsSource = Enum.GetValues(typeof(BO.Category ));
             
        }

        private void cmbCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox? cb = sender as ComboBox ;
            //ComboBox cb = sender as ComboBox??new ComboBox () ;
            BO.Category selectedCategory = ((BO.Category?)cb.SelectedItem)?? BO.Category.All ;
            lvProducts.ItemsSource = bl.Product.GetAll(selectedCategory!=0? f=>f.Category==selectedCategory:a=>true );
          categories=  Enum.GetValues<BO.Category>().ToList();
        //     categories.Remove(selectedCategory );
            cb.ItemsSource = categories;
         }
    }
}

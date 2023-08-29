using Shop.Models;
using Shop.ViewModels;
using Shop.Views;
using System.Collections.ObjectModel;
using System.Windows;

namespace Shop
{

    public partial class MainWindow : Window
    {
        private BucketWindow? _window;
        private bool _isBucketOpen = false;

        private MainViewModel ViewModel { get; } = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModel;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_isBucketOpen) return;
            _window = new BucketWindow();
            _window.Show();
            _isBucketOpen = true;
        }

        private void viewBusket1_Click(object sender, RoutedEventArgs e)
        {
            if(_isBucketOpen)
            {
                var bucketVm = (_window?.DataContext as BucketViewModel);
                if (bucketVm != null) bucketVm.Count += 10;
            }
        }
    }


}

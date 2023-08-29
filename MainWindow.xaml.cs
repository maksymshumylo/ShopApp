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

        private MainViewModel ViewModel { get; } = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = ViewModel;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _window = new BucketWindow();
            _window.Show();
        }
    }


}

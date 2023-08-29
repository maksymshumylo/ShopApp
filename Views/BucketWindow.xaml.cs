using CommunityToolkit.Mvvm.DependencyInjection;
using Shop.ViewModels;
using System.Diagnostics.Eventing.Reader;
using System.Windows;

namespace Shop.Views;

public partial class BucketWindow : Window
{
    private BucketViewModel bucketViewModel = new();
    public BucketWindow()
    {
        InitializeComponent();
        DataContext = bucketViewModel;
        //DataContext = Ioc.Default.GetService<BucketViewModel>();
    }
}

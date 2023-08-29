namespace Shop.ViewModels;
public partial class BucketViewModel : ViewModelBase
{
    public BucketViewModel()
    {
		Count = 100;
    }

    private int _count;
    public int Count
	{
		get => _count;
		set
		{
			SetProperty(ref _count, value);
		}
	}

}

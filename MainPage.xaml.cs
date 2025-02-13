namespace CarouselLeaks;

public partial class MainPage
{
	private MainViewModel _viewModel { get; }

	public MainPage()
	{
		InitializeComponent();
		BindingContext = _viewModel = new MainViewModel();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		_viewModel.Refresh();
	}
}

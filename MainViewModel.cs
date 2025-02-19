using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CarouselLeaks;

public partial class MainViewModel : ObservableObject
{
	private int _counter { get; set; }

	[ObservableProperty]
	public partial IEnumerable<string> Items { get; set; }

	[ObservableProperty]
	public partial string SelectedItem { get; set; }

	[RelayCommand]
	public void Refresh()
	{
		var items = Enumerable.Range(_counter, 10).Select(i => $"Item {i}").ToList();
		var selectedItem = items[0];
		_counter += 10;

		MainThread.BeginInvokeOnMainThread(() =>
		{
			Items = items;
			SelectedItem = selectedItem;
		});
	}

	[RelayCommand]
	public void Collect()
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
		GC.Collect();
	}
}

using CollectionViewSelectedItemBug.Models;

namespace CollectionViewSelectedItemBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		cV.ItemsSource = new List<ListItem>
		{
			new ListItem { DisplayText = "Item1"},
            new ListItem { DisplayText = "Item2"},
            new ListItem { DisplayText = "Item3"}
        };
	}

    private void cV_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		;
    }
}


using TravelApp.ViewModels;

namespace TravelApp.Views;

public partial class TravelPage : ContentPage
{
	public TravelPage(TravelViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
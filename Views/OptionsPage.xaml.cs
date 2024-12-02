namespace LoginFlow.Views;

public partial class OptionsPage : ContentPage
{
	public OptionsPage(OptionsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

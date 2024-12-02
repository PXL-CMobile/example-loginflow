namespace LoginFlow.Views;

public partial class TestPage : ContentPage
{
	public TestPage(TestViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

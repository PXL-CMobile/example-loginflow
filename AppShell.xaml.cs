namespace LoginFlow;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ListDetailDetailPage), typeof(ListDetailDetailPage));
		Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
    }
}

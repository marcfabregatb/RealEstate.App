namespace RealEstate.App;

public partial class App : Application
{
	public App(AppShell appShell)
	{
		InitializeComponent();

		MainPage = appShell;
	}
}

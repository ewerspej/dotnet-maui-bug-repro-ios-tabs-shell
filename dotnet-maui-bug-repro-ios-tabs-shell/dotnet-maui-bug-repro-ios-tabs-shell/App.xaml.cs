namespace dotnet_maui_bug_repro_ios_tabs_shell;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

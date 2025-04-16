using System.Collections.ObjectModel;

namespace Sowao_ContactsMVVM;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}

namespace Sowao_ContactsMVVM;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("Views/ContactsPage", typeof(Views.ContactsPage));
        Routing.RegisterRoute("Views/MainPage", typeof(Views.MainPage));
        Routing.RegisterRoute("Views/ContactDetailsPage", typeof(Views.ContactDetailsPage));
	}
}

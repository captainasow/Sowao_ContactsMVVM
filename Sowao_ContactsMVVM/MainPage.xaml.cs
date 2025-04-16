using Sowao_ContactsMVVM.ViewModels.ContactsViewModel;
using Contact = Sowao_ContactsMVVM.Models.Contact;

namespace Sowao_ContactsMVVM;

public partial class MainPage : ContentPage
{
	private ContactsViewModel vm;

	public MainPage(ContactsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = vm = viewModel;
	}

	private void OnSaveClicked(object sender, EventArgs e)
	{
		var newContact = new Contact
            {
                Name = nameEntry.Text,
                Email = emailEntry.Text,
                PhoneNumber = phoneEntry.Text,
                Description = descriptionEditor.Text
            };
            vm.AddContactCommand.Execute(newContact);
	}
}


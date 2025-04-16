using Contact = Sowao_ContactsMVVM.Models.Contact;

namespace Sowao_ContactsMVVM;

public partial class ContactsPage : ContentPage
{
    private ContactsViewModel vm;

    public string ContactDetailsPage { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public ContactsPage(ContactsViewModel viewModel)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    {
        InitializeComponent();
        BindingContext = vm = viewModel;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private async void OnContactSelected(object sender, EventArgs e)
    {
        // Get the tapped contact from the sender (which is the Frame)
        var frame = sender as Frame;
        var contact = frame?.BindingContext as Contact;

        if (contact != null)
        {
            vm.SelectContactCommand.Execute(contact);
            await Shell.Current.GoToAsync(nameof(ContactDetailsPage));
        }
    }

    private async void OnAddMoreClicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync("MainPage");
    }
}

public class ContactsViewModel
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public object SelectContactCommand { get; internal set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
}
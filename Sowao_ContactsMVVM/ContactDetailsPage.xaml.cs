using Sowao_ContactsMVVM.ViewModels;
using Contact = Sowao_ContactsMVVM.Models.Contact;


namespace Sowao_ContactsMVVM.Views;

public partial class ContactsDetailPage : ContentPage
{
    private ContactsViewModel vm;

    private bool isEditing = false;

    public ContactsDetailPage(ContactsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = vm = viewModel;
    }

    private void OnEditClicked(object sender, EventArgs e)
    {
        isEditing = true;
        SetEditable(true);
    }

    private void OnSaveClicked(object sender, EventArgs e)
    {
        var updated = new Contact
        {
            Name = nameEntry.Text,
            Email = emailEntry.Text,
            PhoneNumber = phoneEntry.Text,
            Description = descriptionEditor.Text
        };
        vm.UpdateContactCommand.Execute(updated);
        SetEditable(false);
        isEditing = false;
    }

    private void SetEditable(bool editable)
    {
        nameEntry.IsEnabled = editable;
        emailEntry.IsEnabled = editable;
        phoneEntry.IsEnabled = editable;
        descriptionEditor.IsEnabled = editable;
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..", true);
    }
}
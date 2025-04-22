using Microsoft.Maui.Controls;
using Sowao_ContactsMVVM.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using ViewModels = Sowao_ContactsMVVM.ViewModels;

namespace Sowao_ContactsMVVM.Views
{
    public partial class MainPage : ContentPage
    {
        public ViewModels.ContactsViewModel ViewModel { get; }

        public MainPage(ViewModels.ContactsViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            BindingContext = ViewModel;
        }

        // Ensure that this method matches the correct event handler signature
       private async void OnSaveClicked(object sender, EventArgs e)
{
    if (ViewModel == null)
    {
        Debug.WriteLine("ViewModel is null");
        return;
    }

    var newContact = new AppContact(
        nameEntry.Text,
        emailEntry.Text,
        phoneEntry.Text,
        descriptionEditor.Text
    );

    Debug.WriteLine($"Contact created: {newContact.Name}, {newContact.Email}, {newContact.PhoneNumber}");

    // Add to ObservableCollection
    ViewModel.AddContactCommand.Execute(newContact);

    // Navigate to ContactsPage which will now show the new contact
    await Navigation.PushAsync(new ContactsPage(ViewModel));
}


    }
}

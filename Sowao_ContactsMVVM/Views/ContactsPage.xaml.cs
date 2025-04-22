using Sowao_ContactsMVVM.Models;
using Microsoft.Maui.ApplicationModel.Communication;
using System.Windows.Input;
using ViewModels = Sowao_ContactsMVVM.ViewModels;  // Use the correct namespace for ViewModels

namespace Sowao_ContactsMVVM.Views
{
    public partial class ContactsPage : ContentPage
    {
        private ViewModels.ContactsViewModel vm;  // Correctly use ViewModels.ContactsViewModel

        public ContactsPage(ViewModels.ContactsViewModel viewModel)  // Accept ViewModels.ContactsViewModel as parameter
        {
            InitializeComponent();
            BindingContext = vm = viewModel;  // Set the BindingContext to the passed ViewModel
        }

        private async void OnContactSelected(object sender, EventArgs e)
        {
            var frame = sender as Frame;
            var contact = frame?.BindingContext as AppContact;  // Fully qualify AppContact

            if (contact != null)
            {
                vm.SelectContactCommand.Execute(contact);  // Now SelectContactCommand should be available
                await Navigation.PushAsync(new ContactsDetailPage(vm));
            }
        }

        private async void OnAddMoreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(vm));  // Pass the ViewModel to MainPage
        }
    }
}

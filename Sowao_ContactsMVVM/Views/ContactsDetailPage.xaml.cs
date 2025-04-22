using Sowao_ContactsMVVM.ViewModels;
using Sowao_ContactsMVVM.Models;
using Microsoft.Maui.Controls;

namespace Sowao_ContactsMVVM.Views;

[QueryProperty(nameof(Contact), "Contact")]

    public partial class ContactsDetailPage : ContentPage
    {
        private ContactsViewModel vm;

        public ContactsDetailPage(ContactsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = vm = viewModel;
        }

        private void OnEditClicked(object sender, EventArgs e)
        {
            SetEditable(true);
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            var updated = new Sowao_ContactsMVVM.Models.AppContact(
                nameEntry.Text,
                emailEntry.Text,
                phoneEntry.Text,
                descriptionEditor.Text
            );

            // Comment out the line that causes the error for now
            // vm.UpdateContactCommand.Execute(updated);  // This should now work correctly after defining UpdateContactCommand

            SetEditable(false);
        }

        private void SetEditable(bool editable)
        {
            nameEntry.IsEnabled = editable;
            emailEntry.IsEnabled = editable;
            phoneEntry.IsEnabled = editable;
            descriptionEditor.IsEnabled = editable;
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(vm));
        }
    }


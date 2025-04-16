using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contact = Sowao_ContactsMVVM.Models.Contact;
using System.Collections.ObjectModel;

namespace Sowoa_ContactsMVVM.ViewModels
{
    public partial class ContactViewModel : ObservableObject
    {
        [ObservableProperty]

        private ObservableCollection<Contact> contacts = new();

        [ObservableProperty]

        private Contact selectedContact;
        
        [RelayCommand]

        private async Task AddContact(Contact contact)
        {
            Contacts.Add(item: contact);
            await Shell.Current.GoToAsync(nameof(ContactsPage));

        }

        [RelayCommand]
        private async Task SelectContact(Contact contact)
        {
            SelectedContact = contact;
            await Shell.Current.GoToAsync(nameof(ContactDetailsPage));
        }

        [RelayCommand]
        private void UpdateContact(Contact updatedContact)
        {
            var index = Contacts.IndexOf(SelectedContact);
            if (index >= 0)
            {
                Contacts[index] = updatedContact;
            }
        }
    }
}

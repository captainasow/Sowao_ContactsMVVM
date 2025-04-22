using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Sowao_ContactsMVVM.Models;

namespace Sowao_ContactsMVVM.ViewModels
{
    public class ContactsViewModel
    {
        public ObservableCollection<AppContact> Contacts { get; set; }
        public ICommand AddContactCommand { get; }
        public ICommand UpdateContactCommand { get; }
        public ICommand SelectContactCommand { get; }  // Add SelectContactCommand

        public ContactsViewModel()
        {
            Contacts = new ObservableCollection<AppContact>();
            AddContactCommand = new Command<AppContact>((contact) => AddContact(contact));
            UpdateContactCommand = new Command<AppContact>((updatedContact) => UpdateContact(updatedContact));
            SelectContactCommand = new Command<AppContact>((contact) => SelectContact(contact));  // Implement the command
        }

        private void AddContact(AppContact contact)
        {
            Contacts.Add(contact);
        }

        private void UpdateContact(AppContact updatedContact)
        {
            var contact = Contacts.FirstOrDefault(c => c.Name == updatedContact.Name);
            if (contact != null)
            {
                contact.Name = updatedContact.Name;
                contact.Email = updatedContact.Email;
                contact.PhoneNumber = updatedContact.PhoneNumber;
                contact.Description = updatedContact.Description;
            }
        }

        // Define what happens when a contact is selected
        private void SelectContact(AppContact contact)
        {
            if (contact != null)
            {
                // Logic when a contact is selected (e.g., update a detail view, navigate, etc.)
                // Example logic can be added here
            }
        }
    }
}

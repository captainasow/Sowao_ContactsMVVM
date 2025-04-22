namespace Sowao_ContactsMVVM.Models
{
    public class AppContact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }

        public AppContact(string name, string email, string phoneNumber, string description)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Description = description;
        }
    }
}

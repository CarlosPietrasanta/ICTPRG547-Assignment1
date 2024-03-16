namespace Assignment1.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }

        private const string DEFAULT_NAME = "No Name Provided";
        private const string DEFAULT_EMAIL = "No Email Provided";
        private const string DEFAULT_PHONE_NUMBER = "No Phone Number Provided";
        private static readonly Address DEFAULT_ADDRESS = new Address();

        public Person()
        {
            Name = DEFAULT_NAME;
            Email = DEFAULT_EMAIL;
            PhoneNumber = DEFAULT_PHONE_NUMBER;
            Address = DEFAULT_ADDRESS;
        }

        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override string ToString()
        {
            return $"\t\tName: {Name}\n" +
                   $"\t\tEmail: {Email}\n" +
                   $"\t\tPhone Number: {PhoneNumber}\n" +
                   $"\t\tAddress: {Address}";
        }
    }
}

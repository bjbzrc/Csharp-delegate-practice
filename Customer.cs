using System;

namespace BrandonButtlarChallengeM7
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;
        private string id;

        public Customer() {}

        public Customer(string firstName, string lastName, string email, string id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ID = id;
        }

        // Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        // Methods
        public string GetDisplayText()
        {
            return $"{firstName} {lastName}, {email}, ID: {id}";
        }
    }
}

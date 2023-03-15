using System;
using System.Collections.Generic;

namespace BrandonButtlarChallengeM7
{
    public class CustomerList
    {
        private List<Customer> customers;

        public CustomerList()
        {
            customers = new List<Customer>();
        }

        // Read only property (it has no setter)
        public int Count
        {
            get { return customers.Count; }
        }

        // Indexer
        public Customer this[int index] => customers[index];

        // Methods
        public void Add(Customer customer)
        {
            customers.Add(customer);
            OnChanged();
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
            OnChanged();
        }

        // Delegates and Events
        public event ChangeHandler Changed;
        public delegate void ChangeHandler(CustomerList customers);

        private void OnChanged() => Changed?.Invoke(this);
    }
}

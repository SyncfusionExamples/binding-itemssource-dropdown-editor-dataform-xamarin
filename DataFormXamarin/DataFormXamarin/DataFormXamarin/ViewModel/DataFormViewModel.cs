using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{
    public class DataFormViewModel
    {
        private ContactInfo contactsInfo;
        private IList<Address> addresses;
        public ContactInfo ContactsInfo
        {
            get { return contactsInfo; }
            set { contactsInfo = value; }
        }
        public IList<Address> Addresses
        {
            get { return this.addresses; }
            set { this.addresses = value; }
        }
        public DataFormViewModel()
        {
            contactsInfo = new ContactInfo();
            addresses = new List<Address>();
            addresses.Add(new Address() { City = "Chennai", PostalCode = 1 });
            addresses.Add(new Address() { City = "Paris", PostalCode = 2 });
            addresses.Add(new Address() { City = "Vatican", PostalCode = 3 });
        }
    }
}

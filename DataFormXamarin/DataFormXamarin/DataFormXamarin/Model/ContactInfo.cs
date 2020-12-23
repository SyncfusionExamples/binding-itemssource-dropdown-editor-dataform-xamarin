using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataFormXamarin
{
    public class ContactInfo : INotifyPropertyChanged
    {
        private string country;
        private string firstName;
        private string lastName;
        public ContactInfo()
        {

        }
        public String FirstName
        {
            get { return firstName; }
            set
            {
                if (value != firstName)
                {
                    firstName = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        public String LastName
        {
            get { return lastName; }
            set
            {
                if (value != lastName)
                {
                    lastName = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        public String Country
        {
            get { return country; }
            set
            {
                if (value != country)
                {
                    country = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String PropertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}

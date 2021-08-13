using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMSample.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string phone;
        private string address;

        public String Name
        {
            get => name; set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public String Phone
        {
            get => phone; set
            {
                phone = value;
                OnPropertyChanged();
            }
        }
        public String Address
        {
            get => address; set
            {
                address = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMSample.Models;
using Xamarin.Forms;

namespace MVVMSample
{
    public partial class MainPage : ContentPage
    {
        public Person CurrentPerson { get; set; }
        public MainPage()
        {
            InitializeComponent();
            LoadData();
            BindingContext = CurrentPerson;
            //txtName.BindingContext = CurrentPerson;
            //txtName.SetBinding(Entry.TextProperty, "Name");
            //Binding personBinding = new Binding();
            //personBinding.Source  = CurrentPerson;
            //personBinding.Path    = "Name";
            //txtName.SetBinding(Entry.TextProperty, personBinding);
        }

        private void LoadData()
        {
            // Conectadon a servicio web
            CurrentPerson = new Person
            {
                Name = "Hector",
                Address = "X Addredd",
                Phone = "12312743128"
            };
            //txtName.Text = CurrentPerson.Name;
            //txtPhone.Text = CurrentPerson.Phone;
            //txtAddress.Text = CurrentPerson.Address;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            //DisplayAlert("Saving","Saving Data","Ok");
            CurrentPerson.Name = "Chofis";
            CurrentPerson.Address = "Address";
            CurrentPerson.Phone = "1293129481";
        }
    }
}

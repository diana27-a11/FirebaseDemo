using FirebaseDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirebaseDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEmployee : ContentPage
    {
        public IList<EmployeeModel> EmployeeModel { get; set; }
        public ListEmployee()
        {
            EmployeeModel = new List<EmployeeModel>();

            EmployeeModel.Add(new EmployeeModel
            {
                FirstName = "Diana",
                LastName = "Rebollar",
                Gender = "Mujer",
                MobileNumber = "5542179054",
                Position = "No se",
                Email = "diana@gmail.com",

            });

            EmployeeModel.Add(new EmployeeModel
            {
                FirstName = "Diana",
                LastName = "Rebollar",
                Gender = "Mujer",
                MobileNumber = "5542179054",
                Position = "No se",
                Email = "diana@gmail.com",

            });

            BindingContext = this;
        }
        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EmployeeModel selectedItem = e.CurrentSelection[0] as EmployeeModel;
        }

    }
}
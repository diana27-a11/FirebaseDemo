﻿using FirebaseDemo.Models;
using FirebaseDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirebaseDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeList : ContentPage
    {
        public EmployeeList()
        {
            InitializeComponent();
            this.BindingContext = new EmployeeListPageViewModel();
        }


        //public EmployeeList(EmployeeModel employee)
        //{
        //    InitializeComponent();
        //    this.BindingContext = new EmployeeListPageViewModel(employee);
        //}
    }
}
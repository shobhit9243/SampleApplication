﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoApp
{
    public partial class ListEmployee : ContentPage
    {
        public ListEmployee()
        {
            InitializeComponent();
            this.BindingContext = new EmployeeViewModel();
        }
    }
}

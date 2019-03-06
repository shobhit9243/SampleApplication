using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoApp
{
    public partial class DetailsEmployee : ContentPage
    {
        EmployeeViewModel evm;
        Employee emp;
        public DetailsEmployee(Employee empdetail=null)
        {
            InitializeComponent();
            emp = empdetail;
            this.BindingContext = ViewModelLocator.MainViewModel;
           // emp = empdetail;
           //// evm = new EmployeeViewModel();
           //// name.Text = empdetail.Name;
            //address.Text = empdetail.Address;
            //designation.Text = empdetail.Designation;
            //nationality.Text = empdetail.Nationality;
            //dob.Text = empdetail.DOB;
            //sex.Text = empdetail.Sex;
            //uimg.Source = empdetail.Imagepath;
            //evm = new EmployeeViewModel();
            //this.BindingContext = evm;
            //var a = evm.EmployeeModel;

        }

        //void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //    ViewModelLocator.MainViewModel.addemployee(emp);
        //  //  evm.addemployee(emp);
        //    //throw new NotImplementedException();
        //}

        //void Handle_Clicked_1(object sender, System.EventArgs e)
        //{
        //    Xamarin.Forms.DependencyService.Register<INativePages>();
        //    DependencyService.Get<INativePages>().StartActivityInAndroid();
        //   // Navigation.PopAsync();
        //    //throw new NotImplementedException();
        //}
    }
}

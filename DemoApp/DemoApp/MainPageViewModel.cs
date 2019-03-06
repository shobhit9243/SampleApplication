using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace DemoApp
{
    public class EmployeeViewModel:INotifyPropertyChanged
    {
       public event PropertyChangedEventHandler PropertyChanged;    
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")  
        {  
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  
        }
        public ICommand CMDAddEmployee { private set; get; }
        public ICommand CMDAShowNative { private set; get; }

        // public List<Employee> Employees { get; set; }
        private List<Employee> _employeeModel=new List<Employee>();
        public List<Employee> Employees
        {
            get
            {
                return _employeeModel;
            }
            set
            {
                _employeeModel = value;
                NotifyPropertyChanged();
            }
        }
        private Employee _employee;
        public Employee EmployeeModel
        {
            get
            {
                return _employee;
            }
            set
            {
                _employee = value;
                NotifyPropertyChanged();
            }
        }
        public EmployeeViewModel()
        {
            Employees = AppSingleton.Employeee;
            CMDAddEmployee = new Command(() =>
            {
                AddUser();
            });
            CMDAShowNative = new Command(() =>
            {
                ShowNativeView();
            });
        }

        private void ShowNativeView()
        {
            Xamarin.Forms.DependencyService.Register<INativePages>();
            DependencyService.Get<INativePages>().StartActivityInAndroid();
        }

        private void AddUser()
        {
            _employeeModel.Add(EmployeeModel);
        }

        public void addemployee(Employee emp)
        {
            _employee = emp;
            _employeeModel.Add(emp);
            AppSingleton.jsonData= JsonConvert.SerializeObject(_employeeModel, Formatting.Indented);           
        }
    }
}
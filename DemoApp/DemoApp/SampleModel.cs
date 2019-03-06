using System;
using System.Collections.Generic;

namespace DemoApp
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public string Nationality { get; set; }
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string Imagepath { get; set; }
        //List<Employee> listEmployee = new List<Employee>();
        //public List<Employee> getEmployee()
        //{
        //    listEmployee = new List<Employee>()
        //    {
        //        new Employee() {
        //            Name = "employee1",
        //            Address = "address 1",
        //            Designation = "designation 1"
        //        },
        //        new Employee() {
        //            Name = "employee2",
        //            Address = "address 2",
        //            Designation = "designation 2"},
        //        new Employee() {
        //            Name = "employee3",
        //            Address = "address 3",
        //            Designation = "designation 3"
        //        }
        //    };
        //    return listEmployee;
        //}
        //public List<Employee> AddEmployee(Employee emp)
        //{
        //    listEmployee.Add(emp);
        //    return listEmployee;
        //}
    }
    public static class ViewModelLocator
    {
        private static EmployeeViewModel _myViewModel = new EmployeeViewModel();
        public static EmployeeViewModel MainViewModel
        {
            get
            {
                return _myViewModel;
            }
        }
    }

}

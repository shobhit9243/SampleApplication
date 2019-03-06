using System;
using System.Collections.Generic;

namespace DemoApp
{
    public static class AppSingleton
    {
        public static List<Employee> Employeee { get; set; }
        public static string jsonData { get; set; }
        static AppSingleton()
        {
            Employeee = new List<Employee>();

        }

    }
}

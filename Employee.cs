using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace gridTableTest
{
    public class Employee
    {
        public Employee(String name, String companyName, String title)
        {
            this.Name = name;
            this.CompanyName = companyName;
            this.Title = title;
        }
        public string Name
        {
            get;
            set;
        }
        public string CompanyName
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
    }
}

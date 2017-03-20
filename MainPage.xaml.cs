using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace gridTableTest
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            PopulateData();
        }

        public void PopulateData()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            employees.Add(new Employee("andre aaa", "EiEi", "Sale"));
            this.radDataPager.Source = employees;
        }
    }
}

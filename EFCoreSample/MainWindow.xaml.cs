using Data.Model.Entity;
using Data.Model.Service;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EFCoreSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       // EmployeeDataAccess EmployeeDataAccess = new EmployeeDataAccess();
        CreateCustomer CustomerDataAccess = new CreateCustomer();
        RemoveCustomer removecustomer=new RemoveCustomer();
        UpdateCustomer updatecustomer=new UpdateCustomer();
        AddCustomer CustomerDataAccess_add = new AddCustomer(); 
        //ProductDataAccess productDataAccess = new ProductDataAccess();
        //List<CustomerlistDTO>customerlistDTOs = new List<CustomerlistDTO>();
        public Employee CurrentEmployee { get; set; } = new Employee();
        public Customer CurrentCustomer { get; set; } = new Customer();
        public Product CurrentProduct { get; set; } = new Product();
     
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Customer> Customers = new ObservableCollection<Customer>();
        ObservableCollection<Product> product = new ObservableCollection<Product>();

        public MainWindow()
        {
            InitializeComponent();
            fillData();
            int a;
            a = 10;
            customergrid.ItemsSource= Customers;
        }

        public void fillData()
        {
            // employees = EmployeeDataAccess.employees;
            Customers.Clear();
            foreach (var customerlistDTO in CustomerDataAccess.exe())
            {
                Customer customer = new Customer()
                {
                    Id = customerlistDTO.id,
                    FirstName = customerlistDTO.firstname,
                    LastName = customerlistDTO.lastname,
                    phone = customerlistDTO.phonenumber
                };
            Customers.Add(customer);
                
            }
         
            //product = productDataAccess.Products;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Employees.Visibility = Visibility.Collapsed;
            Home.Visibility = Visibility.Collapsed;
            customers.Visibility = Visibility.Visible;
            productss.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Employees.Visibility = Visibility.Visible;
            Home.Visibility = Visibility.Collapsed;
            productss.Visibility = Visibility.Collapsed;
            customers.Visibility = Visibility.Collapsed;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Employees.Visibility = Visibility.Collapsed;
            Home.Visibility = Visibility.Visible;
            productss.Visibility = Visibility.Collapsed;
            customers.Visibility = Visibility.Collapsed;

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Employees.Visibility = Visibility.Collapsed;
            Home.Visibility = Visibility.Collapsed;
            productss.Visibility = Visibility.Visible;
            customers.Visibility = Visibility.Collapsed;
        }

        private void employeesgrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (employeesgrid.SelectedIndex >= 0)
            {
                CurrentEmployee = employeesgrid.SelectedItem as Employee;
                contentChange.Content = CurrentEmployee.GetBasicInformation();
            }
        }

        private void customergrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (customergrid.SelectedIndex >= 0)
            {
                CurrentCustomer = customergrid.SelectedItem as Customer;
                customerchange.Content = CurrentCustomer.GetBasicInformation();
            }
        }

        private void productgird_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (productgird.SelectedIndex >= 0)
            {
                CurrentProduct = productgird.SelectedItem as Product;
                //productchange.Content = CurrentProduct.getbasicinformation();
            }
        }

       private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
           // AddEditEmployee addEditEmployee = new AddEditEmployee(EmployeeDataAccess);
           // addEditEmployee.ShowDialog();
        }

        private void EditEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (employeesgrid.SelectedIndex >= 0)
            {
                CurrentEmployee = employeesgrid.SelectedItem as Employee;
              //  AddEditEmployee addEditEmployee = new AddEditEmployee(EmployeeDataAccess, CurrentEmployee);
              //  addEditEmployee.ShowDialog();

            }
        }

        private void RemoveEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (employeesgrid.SelectedIndex >= 0)
            {
                CurrentEmployee = employeesgrid.SelectedItem as Employee;
             //   EmployeeDataAccess.RemoveEmployee(CurrentEmployee.id);
                contentChange.Content = "---";
            }
        }

        private void AddProductbtn_Click(object sender, RoutedEventArgs e)
        {
           // AddEditProduct addEditProduct = new AddEditProduct(productDataAccess);
          //  addEditProduct.ShowDialog();

        }

        private void EditProductbtn_Click(object sender, RoutedEventArgs e)
        {
            CurrentProduct = productgird.SelectedItem as Product;
           // AddEditProduct addEditProduct = new AddEditProduct(productDataAccess, CurrentProduct);

            //addEditProduct.ShowDialog();

        }

        private void RemoveProductbtn_Click(object sender, RoutedEventArgs e)
        {
            if (productgird.SelectedIndex >= 0)
            {
                CurrentProduct = productgird.SelectedItem as Product;
               // productDataAccess.Delete_Product(CurrentProduct.id);
                productchange.Content = "---";
            }
        }

        private void AddCustomerbtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditCustomer addEditCustomer = new AddEditCustomer(CustomerDataAccess_add);
            addEditCustomer.ShowDialog();
            fillData();
        }

        private void EditCustomerbtn_Click(object sender, RoutedEventArgs e)
        {
                //  AddEditCustomer addEditCustomer = new AddEditCustomer(CreateCustomer, CurrentCustomer);
                //addEditCustomer.ShowDialog();
                if (customergrid.SelectedIndex >= 0)
                {
                    CurrentCustomer = customergrid.SelectedItem as Customer;
                    AddEditCustomer addEditCustomer = new AddEditCustomer(updatecustomer, CurrentCustomer);
                    addEditCustomer.ShowDialog();
                    fillData();

            }
        }

        private void RemoveCustomerbtn_Click(object sender, RoutedEventArgs e)
        {
            if (customergrid.SelectedIndex >= 0)
            {
                CurrentCustomer = customergrid.SelectedItem as Customer;
                removecustomer.Removing(CurrentCustomer.Id);
                customerchange.Content = "---";
                fillData();
            }
        }
    }
}
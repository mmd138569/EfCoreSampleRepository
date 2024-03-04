using Data.Model.Entity;
using Data.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EFCoreSample
{
    /// <summary>
    /// Interaction logic for AddEditCustomer.xaml
    /// </summary>
    public partial class AddEditCustomer : Window
    {

        Boolean isEdinting = false;
        int a;
        private CreateCustomer customerdataaccess;
        private UpdateCustomer updateCustomer;
        public AddCustomer customer_dataAccess_add;
        private Customer EditingCutomer;
        public AddEditCustomer()
        {
            InitializeComponent();
        }
        public AddEditCustomer(AddCustomer cust)
        {
            InitializeComponent();

            customer_dataAccess_add = cust;
        }
        public AddEditCustomer(UpdateCustomer customerData, Customer customee)
        {
            InitializeComponent();

            updateCustomer = customerData;
            
            EditingCutomer = customee;
             a=customee.Id;
            CustomerName.Text = customee.FirstName;
            CustomerLastName.Text = customee.LastName;
            PhoneNumber.Text = customee.phone.ToString();
            isEdinting = true;

        }
        private void Cancel_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isEdinting)
            {

                Customer customer = new Customer()
                {
                    // Id = customerdataaccess.NextCustomer(),
                    FirstName = CustomerName.Text,
                    LastName = CustomerLastName.Text,
                    phone = Convert.ToUInt64(PhoneNumber.Text),
                };
                customer_dataAccess_add.add(customer);
                this.Close();
            }
            else
            {
                Customer custome = new Customer()
                {
                    FirstName = CustomerName.Text,
                    LastName = CustomerLastName.Text,
                    phone = Convert.ToUInt64(PhoneNumber.Text)
                };
                updateCustomer.update(custome,a);
                this.Close();
            }
        }

    }
}


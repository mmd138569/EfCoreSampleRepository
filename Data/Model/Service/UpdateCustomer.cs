using Data.Model.Context;
using Data.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Service
{
    public class UpdateCustomer:IUpdateCustomer
    {
        public readonly DataBaseContext context;

        public UpdateCustomer()
        {
            context = new DataBaseContext();
        }
        public void update(Customer customer, int a)
        {
            /* EntityEntry<Customer> entityEntry = context.Entry<Customer>(customer);
             PropertyValues propertyValue = entityEntry.CurrentValues;
             propertyValue.SetValues(customer);
            */  
            ////bujg


            Customer temp = context.customers.FirstOrDefault(p => p.Id == a);
            temp.FirstName = customer.FirstName;
            temp.phone = customer.phone;
            temp.LastName = customer.LastName;
            //context.customers.Remove(temp);
            //context.customers.Add(customer);
            context.SaveChanges();
        }
    }
}

using Data.Model.Context;
using Data.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Service
{
    public class AddCustomer : IAddCustomer
    {
      
        private readonly DataBaseContext context;
        public AddCustomer()
        {
            context =  new DataBaseContext();
        }
        public void add(Customer customer)
        {
            context.customers.Add(customer);
            context.SaveChanges();

        }
    }
}

using Data.Model.Context;
using Data.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Service
{
    public class RemoveCustomer:IRemoveCustomer
    {
        public readonly DataBaseContext context;

        public RemoveCustomer()
        {
            context = new DataBaseContext();
        }
        public void Removing(int id)
        {
            Customer temp = context.customers.First(p => p.Id == id);
            context.customers.Remove(temp);
            context.SaveChanges();

        }
    }
}

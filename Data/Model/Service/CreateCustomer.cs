using Data.Model.Context;
using Data.Model.Entity;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Data.Model.Service
{
    public class CreateCustomer:ICreateCustomer
    {
        public readonly DataBaseContext context;

        public CreateCustomer() 
        {
            context=new DataBaseContext();
        }

        public List<CustomerlistDTO> exe()
        {
            //var customer = context.Set<Customer>().Select(p => new CustomerlistDTO
            var customer = context.customers.Select(p => new CustomerlistDTO
            {
                id = p.Id,
                firstname = p.FirstName,
                lastname = p.LastName,
                phonenumber = p.phone,
            }).ToList();

            return customer;
        }
    

  

      
        /*  public int NextCustomer()
 {
     int nextcustomer = context.customers.Any() ? context.customers.Max(x=>x.Id) + 1 : 1;
     return nextcustomer;
 }*/
        /*   public void update(Customer customer)
           {
               Customer temp=context.customers.First(p=>p.Id == customer.Id);
               var customer = context.customers.Select(p => 
               {
                    p.Id==temp.Id,
                   p.firstname = temp.FirstName,
                   lastname = p.LastName,
                   phonenumber = p.phone,
               }).ToList();
           }*/

    }
}

using Data.Model.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Service
{
    public interface ICreateCustomer
    {
        List<CustomerlistDTO> exe();
    }
    public class CustomerlistDTO
    {
        public int id;
        public string firstname;
        public string lastname;
        public UInt64 phonenumber;
    }
}

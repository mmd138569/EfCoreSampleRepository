using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Entity
{
    public interface IProduct
    {
        int Id { get; set; }    
        string Name { get; set; }
        UInt64 price {  get; set; }
    }
}

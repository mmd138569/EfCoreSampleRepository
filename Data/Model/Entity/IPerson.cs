using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Entity
{
    public interface IPerson
    {
        int Id { get; set; }    
        string FirstName { get; set; }
        string LastName { get; set; }
        UInt64 phone { get; set; }
    }
}

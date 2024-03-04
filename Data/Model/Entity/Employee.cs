using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.Entity
{
    public class Employee : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UInt64 phone { get; set; }
        public string GetBasicInformation()
        {
            return "First Name: "+FirstName+"\n"+
                "Last Name: "+LastName+"\n"
                +"Phone Number: "+phone;
        }
    }
}

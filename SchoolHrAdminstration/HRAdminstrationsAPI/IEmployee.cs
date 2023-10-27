using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminstrationsAPI
{
     public interface IEmployee
    {
       int id { get; set; }
       string Firstname { get; set;}
        string Lastname { get; set;}
        decimal Salary { get; set; }   



    }
}

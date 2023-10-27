using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminstrationsAPI
{
    public class EmployeeBase : IEmployee
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public virtual decimal Salary { get ; set ; }
        public string Lastname { get;set; }
    }
}

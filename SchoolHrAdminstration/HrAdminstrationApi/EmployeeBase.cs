using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAdminstrationApi
{
    public class EmployeeBase : IEmployee
    {
        public int id { get; set; }
        public string Firstname { get ; set ; }
        public string Lastname { get ; set ; }
        public virtual decimal salary { get; set; }
    }
}

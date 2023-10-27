// See https://aka.ms/new-console-template for more information
using HRAdminstrationsAPI;
using System;
using System.Linq;
namespace SchoolHRAdminsration
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalary = 0;
            List<IEmployee> employee = new List<IEmployee>();
            SeedData(employee);


            //1.
            /*  foreach(IEmployee employee1 in employee)
              {
                  totalSalary+= employee1.Salary;
              }
              Console.WriteLine($"Total Anual Salaries(including bonus):{totalSalary}");*/

            //2. way is usng Linq here no need to use foreach loop to calculate totalsalary

            Console.WriteLine($"Total Anual salary(including bonus is ):{employee.Sum(e => e.Salary)}");//Linq 


        }
        public static void SeedData(List<IEmployee> employee)//generic as argunment
        {
            IEmployee teacher1 = new Teacher
            {
                id = 1,
                Firstname = "Bob",
                Lastname = "Biswas",
                Salary = 50000
            };
            employee.Add(teacher1);
            IEmployee teacher2 = new Teacher
            {
                id = 2,
                Firstname = "John",
                Lastname = "Carter",
                Salary = 60000
            };
            employee.Add(teacher2);
            IEmployee teacher3 = new Teacher
            {
                id = 3,
                Firstname = "Bill",
                Lastname = "Warn",
                Salary = 40000
            };
            employee.Add(teacher3);

            IEmployee headofDepartment = new HeadofDeapartment
            {
                id = 10,
                Firstname = "nenci",
                Lastname = "yarn",
                Salary = 80000
            };
            employee.Add(headofDepartment);

            IEmployee deputyheadofDepartment = new DeputyHeadofDeapartment
            {
                id = 9,
                Firstname = "Charles",
                Lastname = "Bayes",
                Salary = 70000
            };
            employee.Add(deputyheadofDepartment);
            IEmployee headMaster = new HeadMAster
            {
                id = 8,
                Firstname = "yunis",
                Lastname = "farkin",
                Salary = 60000
            };
            employee.Add(headMaster);

        }
    }

    public class Teacher:EmployeeBase
    {
        public override decimal Salary { get => base.Salary+(base.Salary*0.02m); }
    }


    public class HeadofDeapartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }
    
    public class DeputyHeadofDeapartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }
    public class HeadMAster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }
}


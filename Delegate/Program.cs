using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 1, Name = "Shakeel", Salary = 40000, Experience = 5 });
            empList.Add(new Employee() { ID = 2, Name = "Bilal", Salary = 30000, Experience = 4 });
            empList.Add(new Employee() { ID = 3, Name = "Zeeshan", Salary = 35000, Experience = 6 });
            empList.Add(new Employee() { ID = 4, Name = "Haris", Salary = 20000, Experience = 3 });

            //Employee.PromoteEmployee(empList);


            //IsPromotable isPromotable = new IsPromotable(Promote);  
            //Employee.PromoteEmployee(empList, isPromotable);

            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
            Console.ReadLine();

        }
        //public static bool Promote(Employee emp)
        //{
        //    if(emp.Experience >=5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
    delegate bool IsPromotable (Employee emp);
    class  Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        //public static void PromoteEmployee(List<Employee> employees)
        //{
        //    foreach (Employee employee in employees)
        //    {
        //        if(employee.Experience >= 5)
        //        {
        //            Console.WriteLine(employee.Name += " promoted");
        //        }
        //    }
        //}
        public static void PromoteEmployee(List<Employee> employees, IsPromotable isEligibleToPromote)
        {
            foreach(Employee employee in employees)
            {
                if (isEligibleToPromote(employee))  
                {
                    Console.WriteLine(employee.Name += " promoted");
                }
            }
        }
    }
}

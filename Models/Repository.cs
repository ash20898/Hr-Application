using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRApplocationAR.Models
{
    public class Repository
    {

        private static List<Employee> allEmployees = new List<Employee>();
        public static IEnumerable<Employee> getAllEmployees()
        {
            return allEmployees;
        }
        public static void addEmployee ( Employee emp)
        {
            allEmployees.Add(emp);
        }


    }
}

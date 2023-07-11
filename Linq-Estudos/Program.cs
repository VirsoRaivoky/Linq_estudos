using System;
using TCPData;
using TCPExtensions;

namespace Linq_Estudos
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Employes> employeList = Data.GetEmployes();
            // Lambda é chamada para filtrar especificamente elementos
            // com a bool retornando true  
            var filteredEmploye = employeList.Filter(emp => emp.isManager == false);

            foreach (var employe in filteredEmploye) 
            {
                Console.WriteLine($"First Name: {employe.FirstName}");
                Console.WriteLine($"Last Name: {employe.LastName}");
                Console.WriteLine($"Annual Salary: {employe.AnnualSalary}");
                Console.WriteLine($"Manager: {employe.isManager}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
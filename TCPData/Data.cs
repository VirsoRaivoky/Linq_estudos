using System;
using System.Collections.Generic;
using System.Text;

namespace TCPData
{
    public static class Data
    {
        public static List<Employes> GetEmployes()
        {
            List<Employes> employes = new List<Employes>();

            Employes employee = new Employes
            {
                Id = 1,
                FirstName = "Wilson",
                LastName = "Xavier",
                AnnualSalary = 6000.3m,
                isManager = true,
                DepartmentId = 1
            };
            employes.Add(employee);

            employee = new Employes
            {
                Id = 2,
                FirstName = "Jose",
                LastName = "R",
                AnnualSalary = 4000.3m,
                isManager = true,
                DepartmentId = 3
            };
            employes.Add(employee);

            employee = new Employes
            {
                Id = 3,
                FirstName = "Heitor",
                LastName = "Santos",
                AnnualSalary = 3000.3m,
                isManager = false,
                DepartmentId = 2
            };
            employes.Add(employee);

            return employes;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            Department department = new Department
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources"
            };
            departments.Add(department);

            department = new Department
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance"
            };
            departments.Add(department);

            department = new Department
            {
                Id = 3,
                ShortName = "TE",
                LongName = "Technology"
            };
            departments.Add(department);

            return departments;
        }
    }
}

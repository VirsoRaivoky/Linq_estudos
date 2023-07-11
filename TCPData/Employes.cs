using System;
using System.Collections.Generic;
using System.Text;

namespace TCPData
{
    public class Employes
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool isManager { get; set; }
        public int DepartmentId { get; set; }
    }
}

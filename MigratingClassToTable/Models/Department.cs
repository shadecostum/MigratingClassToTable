using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratingClassToTable.Models
{
    internal class Department
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }
        public string Location { get; set; }

        public List<Employee> Employees { get; set; }

    }
}

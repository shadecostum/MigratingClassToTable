using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratingClassToTable.Models.Repositary
{
    internal interface IEmployee
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);

        public int Add(Employee employee);

        public bool Update(Employee employee);

        public bool Delete(int EmpId);
    }
}

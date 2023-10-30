using Microsoft.EntityFrameworkCore;
using MigratingClassToTable.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratingClassToTable.Models.Repositary
{
    internal class DepartmentRepo:IDepartmentRep
    {
        private MyContext _context;

        public DepartmentRepo(MyContext context)
        {
            _context = context;
        }


        public List<Department>  GetAllData()
        {
          var data= _context.Department.Include(dept=>dept.Employees).ThenInclude(work=>work.WorkStation)
                .Include(dept => dept.Employees).ThenInclude(emp => emp.Projects)
                .ToList();

            return data;
        }
    }
}

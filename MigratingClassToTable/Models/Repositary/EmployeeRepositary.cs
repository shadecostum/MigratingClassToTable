using Microsoft.EntityFrameworkCore;
using MigratingClassToTable.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratingClassToTable.Models.Repositary
{
    internal class EmployeeRepositary:IEmployee
    {
        private MyContext _context;

        public EmployeeRepositary(MyContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            var employees=_context.Employees.ToList();
            return employees;
        }

        public Employee GetById(int id) 
        {
            return _context.Employees.Where(empl => empl.Id == id).FirstOrDefault();
        }

        public int Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

            var newEmpId=_context.Employees.Where(empl=>empl.EMPName==employee.EMPName).
                OrderBy(empl=>empl.Id).LastOrDefault().Id;
            return newEmpId;
        }


        public bool Update(Employee employee)
        {   
            var employeeToUpdate=GetById(employee.Id);
            if (employeeToUpdate!=null)
            {
                _context.Entry(employeeToUpdate).State = EntityState.Detached;
                _context.Employees.Update(employee);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int EmpId) 
        {
            var employeeToDelete=GetById(EmpId);
            if (employeeToDelete!=null)
            {
                _context.Employees.Remove(employeeToDelete);
                _context.SaveChanges();
                return true;
            }
            return false;
        }



    }
}

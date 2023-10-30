using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratingClassToTable.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string EMPName { get; set; }
        public string Address { get; set; }

        public double Salary { get; set; }


        public WorkStation WorkStation { get; set; }

        [ForeignKey("WorkStation")]
        public int? WorkStationId { get; set; }//fk

        public Department Department { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get;set; }

        public List<Project> Projects { get; set; }


    }
}

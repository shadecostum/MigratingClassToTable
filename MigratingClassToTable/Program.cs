using MigratingClassToTable.Data;
using MigratingClassToTable.Models;
using MigratingClassToTable.Models.Repositary;

namespace MigratingClassToTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDepartmentRep repo=new DepartmentRepo(new MyContext());
            var departments=repo.GetAllData();

            foreach(var department in departments)
            {
                Console.WriteLine($" Department Table \n Id:{department.Id}\t,Name:{department.DepartmentName}\t," +
                    $"location:{department.Location}\n");
               
                Console.WriteLine(new string('-', 50));
                Console.WriteLine($"No Of Emplyess{department.Employees.Count}");

                
                foreach (var emp in department.Employees)
                {
                    Console.WriteLine($"Emplyee ID:{emp.Id}\t,Name:{emp.EMPName}\t,Address:{emp.Address}\t," +
                        $"Salary:{emp.Salary}\n");
                    //  Console.WriteLine($"No of WorkStation:{emp.WorkStation}"); its not list one to one

                    Console.WriteLine(
                        $"****WorkStation Id:{emp.WorkStationId}\tWsCode:{emp.WorkStation.WsCode}\t" +
                        $" Floor:{emp.WorkStation.Floor},");
                        
                    Console.WriteLine( $"\nProject Count:{emp.Projects.Count}");

                    Console.WriteLine(new string('+', 50));

                    //list with many to many
                    foreach (var pro in emp.Projects)
                    {
                        Console.WriteLine($"*******ProjectId:{pro.Id}\tProjectName:{pro.ProjectName}\t," +
                            $"Description:{pro.ProjectDescription}\t");
                        Console.WriteLine(new string('+', 50));
                    }
                  
                }
                Console.WriteLine(new string('=', 50));
            }

        }
    }
}
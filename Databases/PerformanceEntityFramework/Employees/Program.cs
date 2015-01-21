namespace Employees
{
    using System;
    using TelerikAcademyDB;
    using System.Diagnostics;

   public class Program
    {
       public static void Main()
        {
            using (var dbContext = new TelerikAcademyEntities())
            {
                var employees = dbContext.Employees;
                var stopwatchSlow = new Stopwatch();
                stopwatchSlow.Start();

                foreach (var employee in employees)
                {
                    Console.WriteLine("Employee Name: {0} {1}\nEmployee Department: {2}\nEmployee Town: {3}"
                                        , employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
                }

                stopwatchSlow.Stop();
                var stopwatchFaster = new Stopwatch();
                stopwatchFaster.Start();
                var employeesInclude = dbContext.Employees.Include("Address");

                foreach (var employee in employeesInclude)
                {
                    Console.WriteLine("Employee Name: {0} {1}\nEmployee Department: {2}\nEmployee Town: {3}"
                                        , employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
                }

                stopwatchFaster.Stop();
                Console.WriteLine();
                Console.WriteLine("Time elapsed with slower way: " + stopwatchSlow.Elapsed);
                Console.WriteLine("Time elapsed with Include(faster): " + stopwatchFaster.Elapsed);
            }
        }
    }
}
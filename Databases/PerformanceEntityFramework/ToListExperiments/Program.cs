namespace ToListExperiments
{
    using TelerikAcademyDB;
    using System.Linq;

   public class Program
    {
        static void Main()
        {
            using (var dbContext = new TelerikAcademyEntities())
            {
                var employeesSlow = dbContext.Employees.Select(e => e.Address).ToList()
                    .Select(e => e.Town).ToList()
                    .Where(e => e.Name == "Sofia").ToList();
                // It made around 100 requests;

                var employeesFast = dbContext.Employees.Select(e => e.Address)
                    .Select(e => e.Town)
                    .Where(e => e.Name == "Sofia").ToList();
                // It made 2.
            }
        }
    }
}

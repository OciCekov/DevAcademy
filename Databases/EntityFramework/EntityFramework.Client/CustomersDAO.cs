namespace EntityFramework.Client
{
    using System;
    using System.Linq;
    using System.Data.Entity.Infrastructure;

    using EntityDatabaseModel;

    // Customers tests are in the Main method

    public static class CustomersDao
    {
        public static void InsertCustomer(Customer newCustomer, NorthwindEntities context)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();

        }
        public static void RemoveCustomer(string customerID, NorthwindEntities context)
        {
            var unwantedCustomer = context.Customers.First(c => c.CustomerID == customerID);
            context.Customers.Remove(unwantedCustomer);
            context.SaveChanges();
        }
        public static void ModifyCustomer(string customerID, string newCustomerName, NorthwindEntities context)
        {
            var customerToEdit = context.Customers.First(c => c.CustomerID == customerID);
            customerToEdit.ContactName = newCustomerName;
            context.SaveChanges();
        }

        public static IQueryable<Order> FindCustomerOrder(int orderYear, string country, NorthwindEntities context)
        {
            var orders = context.Orders.Where(o => o.OrderDate.Value.Year == orderYear && o.ShipCountry == country);
            orders.Select(o => o.CustomerID);
           
            return orders;
        }

        public static DbRawSqlQuery<string> CustomerOrderSql(int orderYear, string country, NorthwindEntities context)
        {
            var sqlQuery = @"SELECT c.ContactName FROM Customers" +
                              " c INNER JOIN Orders o ON o.CustomerID = c.CustomerID " +
                              "WHERE (YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1});";
 
            object[] parameters = { orderYear, country };
            var sqlQueryResult = context.Database.SqlQuery<string>(sqlQuery, parameters);

            return sqlQueryResult;
        }

        public static void RegionalSalesByPeriod(string region, DateTime startDate, DateTime endDate, NorthwindEntities context)
        {
            var sales = context.Orders.Where(
                                       o => o.ShipRegion == region &&
                                       o.OrderDate >= startDate &&
                                       o.OrderDate <= endDate);
            var salesForDisplay = sales.Select(o => new
            {
                ShipName = o.ShipName,
                OrderDate = o.OrderDate
            });
            foreach (var item in salesForDisplay)
            {
                Console.WriteLine(item.ShipName + " -> " + item.OrderDate);
            }  
        }
    }
}

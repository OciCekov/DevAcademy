namespace EntityFramework.Client
{
    using System;

    using EntityDatabaseModel;

    public class Program
    {
        public static void Main()
        {
            var customer = new Customer()
            {
                CustomerID = "THIS",
                CompanyName = "Jobless",
                ContactName = "MRNobody",
                ContactTitle = "AbsolutelyNobody"
            };

            using (var db = new NorthwindEntities())
            {
                //CustomersDao.InsertCustomer(customer, db);
                //Console.WriteLine("Customer Added");
                //CustomersDao.ModifyCustomer(customer.CustomerID, "Pesho", db);
                //Console.WriteLine("Customer Modified");
                //CustomersDao.RemoveCustomer(customer.CustomerID, db);
                //Console.WriteLine("Customer Deleted");

                var customersWithCurrentOrders = CustomersDao.FindCustomerOrder(1997, "Canada", db);
                foreach (var order in customersWithCurrentOrders)
                {
                    Console.WriteLine(order.Customer.ContactName);
                }

                var viaSQL = CustomersDao.CustomerOrderSql(1997, "Canada", db);
                foreach (var contactName in viaSQL)
                {
                    Console.WriteLine(contactName);
                }

                CustomersDao.RegionalSalesByPeriod("WA", new DateTime(1997, 01, 01),
                                                    new DateTime(1997, 06, 06), db);

                // Well this is what I figured out for task №6
                db.Database.CreateIfNotExists();


            }
        }
    }
}

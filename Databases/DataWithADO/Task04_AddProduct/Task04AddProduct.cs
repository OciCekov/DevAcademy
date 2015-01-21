namespace Task04_AddProduct
{
    using System;
    using System.Data.SqlClient;

    class Task04AddProduct
    {
        //4.Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.

        static void Main(string[] args)
        {
            AddProduct("BlueTable", true);
        }

        static void AddProduct(string name, bool discontinued)
        {
            SqlConnection dbCon = new SqlConnection("Server=.\\; " + "Database=Northwind; Integrated Security=true");
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand addProductInTable = new SqlCommand("INSERT Products (ProductName,Discontinued)" + "VALUES(@name,@discontinued);", dbCon);
                addProductInTable.Parameters.AddWithValue("@name", name);
                addProductInTable.Parameters.AddWithValue("@discontinued", discontinued);
                addProductInTable.ExecuteNonQuery();
            }
        }
    }
}

namespace Task05_RetrievesImages
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Task05
    {
        //5.Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.

        const string FILE_LOCATION = @"..\";
        const string FILE_EXTENSION = @".jpg";

        static void Main()
        {
            ExtractImageFromDB();
        }

        static void ExtractImageFromDB()
        {
            SqlConnection dbConn = new SqlConnection("Server=.\\; " + "Database=Northwind; Integrated Security=true");
            dbConn.Open();

            using (dbConn)
            {
                SqlCommand cmd = new SqlCommand("SELECT PICTURE, CategoryID, CategoryName FROM Categories", dbConn);
                SqlDataReader reader = cmd.ExecuteReader();

                using (reader)
                {
                    byte[] image;
                    int categoryId;
                    string categoryName;
                    while (reader.Read())
                    {
                        image = (byte[])reader["Picture"];
                        categoryId = (int)reader["CategoryID"];
                        categoryName = (string)reader["CategoryName"];
                        WriteBinaryFile(image, FILE_LOCATION + categoryId + FILE_EXTENSION);
                        image = null;
                    }
                }
            }
        }

        static void WriteBinaryFile(byte[] fileContents, string fileLocation)
        {
            FileStream stream = new FileStream(fileLocation, FileMode.Create);
            using (stream)
            {
                stream.Write(fileContents, 0, fileContents.Length);
            }
        }

    }
}

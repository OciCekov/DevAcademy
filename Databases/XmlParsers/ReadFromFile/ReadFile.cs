namespace ReadFromFile
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    internal class ReadFile
    {
        private static void Main()
        {
            string personalFilePath = @"..\..\..\PersonalInformation.txt";
            using (var reader = new StreamReader(personalFilePath))
            {
                string name = reader.ReadLine();
                string address = reader.ReadLine();
                string phone = reader.ReadLine();

                var personElement = new XElement("humans",
                    new XElement("person",
                        new XElement("name", name),
                        new XElement("address", address),
                        new XElement("phone", phone)
                        ));
                personElement.Save(@"..\..\..\Humans.xml");
                Console.WriteLine("Done!");
            }
        }
    }
}
namespace PersonWithUnknownAge
{
    /* Create a class Person with two fields – name and age.
     * Age can be left unspecified (may contain null value. Override ToString()
     * to display the information of a person and if age is not specified – to say so. 
     * Write a program to test this functionality.*/

    using System;

    public class Person
    {
        private string name;
        private int age;

        public Person(string initialName, int initialAge = 0)
        {
            this.Name = initialName;
            this.Age = initialAge;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name must contain parameter");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must have positive value");
                }
                age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\n", this.Name, this.age == 0 ? "Age not specified" : (object)this.Age);
        }
    }
}

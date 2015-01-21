namespace StudentsTasks
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        //Yes this is ugly!!! The other option was to create several classes for students, wasn't sure will it be wrong if it was the other way? 
        public Student(string initialFirstName, string initialSecondName, string initialLastName, int initialSSN,
         string initialHomeAdress, string initialMobilePhone, string initialEmail, int initialCourse,
         UniversityEnum initialUniversity, FacultyEnum initialFaculty, SpecialityEnum initialSpeciality)
        {
            this.FirstName = initialFirstName;
            this.SecondName = initialSecondName;
            this.LastName = initialLastName;
            this.SSN = initialSSN;
            this.HomeAdress = initialHomeAdress;
            this.MobilePhone = initialMobilePhone;
            this.Email = initialEmail;
            this.Course = initialCourse;
            this.University = initialUniversity;
            this.Faculty = initialFaculty;
            this.Speciality = initialSpeciality;
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string HomeAdress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public UniversityEnum University { get; set; }
        public SpecialityEnum Speciality { get; set; }
        public FacultyEnum Faculty { get; set; }

        public override bool Equals(object param)
        {
            var student = param as Student;
            // just to be sure that this is valid student
            if (student == null)
            {
                return false;
            }

            if (this.FirstName != student.FirstName || this.SecondName != student.SecondName || this.LastName != student.LastName || this.SSN != student.SSN)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ SecondName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public object Clone()
        {
            Student original = this;
            var clonedStudent = new Student(this.FirstName, this.SecondName, this.LastName, this.SSN, this.HomeAdress,
                this.MobilePhone, this.Email, this.Course, this.University, this.Faculty, this.Speciality);
            return clonedStudent;
        }

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }

            if (this.SecondName != student.SecondName)
            {
                return (this.SecondName.CompareTo(student.SecondName));
            }

            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }

            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }

            return 0;
        }

        public override string ToString()
        {
            return String.Format("Student(Name: {0} {1} {2}, SSN: {3})", this.FirstName, this.SecondName, this.LastName, this.SSN);
        }
    }
}

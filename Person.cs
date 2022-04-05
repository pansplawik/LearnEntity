using System.ComponentModel.DataAnnotations.Schema;

namespace entityFramework 
{
    [Table("Person")]
    class Person
    {
        public string Name;
        public string Surname;
        public double Age;
    }
    [Table("Student")]
    class Student : Person
    {
        public int ID;
        public string FieldOfStudy;
        public int Term;
    }
    [Table("Worker")]
    class Worker : Person
    {
        public string NameCompany { get; set; }
        public int HowLong { get; set; }
    }
}

using System;
using System.Data.Entity;
namespace entityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
           {
                var studentss = new Student
                {
                    Name = "k",
                    Surname = "s",
                    Age = 20,
                    FieldOfStudy = "Inzynieria Biomedyczna",
                    Term = 4,
                    ID = 21,
                };
                context.Students.Add(studentss);
                context.SaveChanges();
           } 
        
        }
    }
}

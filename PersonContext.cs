using Microsoft.EntityFrameworkCore;

namespace entityFramework
{
    class PersonContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}

using System.Data.Entity;
using MockData.Source.Models;

namespace MockData.Entity
{
    public class PersonContext: DbContext
    {
        public PersonContext(): base("DefaultConnection") { }

        public DbSet<Person> Persons { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateMockDb.Context.Models;

namespace Entity
{
    public class PersonContext: DbContext
    {
        public PersonContext(): base("DefaultConnection") { }

        public DbSet<Person> Persons { get; set; }
    }
}

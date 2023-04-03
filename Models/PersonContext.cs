using Microsoft.EntityFrameworkCore;

namespace crud.Models
{
    public class PersonContext:DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options) {
            
        }
       
        public DbSet<Person> persons {  get; set; } 
    }
}

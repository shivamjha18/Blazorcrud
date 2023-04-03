using crud.Models;

namespace crud.Services
{
    public class PersonService : IPersonService
    {
        private readonly PersonContext _context;
        public PersonService(PersonContext context)
        {
            _context = context;
        }
        public bool AddUpdate(Person person)
        {
            try
            {
                if (person.Id == 0)
                
                    _context.persons.Add(person);
                
                else
                
                    _context.persons.Update(person);
                _context.SaveChanges();
                return true;
                
            }
            catch(Exception ex)
            {
                return false;

            }
        }

        public bool Delete(int id)
        {
            try
            {
                var person = FindById(id);
                if(person == null)
                
                    return false;
                _context.persons.Remove(person);
                _context.SaveChanges();
                return true;
                
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public Person FindById(int id)
        {
            return _context.persons.Find(id);
        }

        public List<Person> GetAll()
        {
            return _context.persons.ToList();
        }
    }
}

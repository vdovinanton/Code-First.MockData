using DataSource;
using Entity;

namespace CreateMockDb
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var repository = new Repository();

            var people = Source.Instance.GetPeople();
            var orders = Source.Instance.GetOrders();

            var mappingPeople = repository.PersonMap(people, orders);

            using (var context = new PersonContext())
            {
                context.Persons.AddRange(mappingPeople);

                context.SaveChanges();
            }
        }
    }
}

using MockData.Source;
using MockData.Entity;

namespace CreateMockDb
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            // TODO: Add gender enum and to tie with People people by one to many 

            var repository = new Repository();

            var people = Source.Instance.GetPeople();
            var orders = Source.Instance.GetOrders();
            var productrs = Source.Instance.GetProducts();

            var mappingProducts = repository.ProductMap(productrs);
            var mappingOrders = repository.OrderMap(orders, mappingProducts);
            var mappingPeople = repository.PersonMap(people, mappingOrders);

            using (var db = new PersonContext())
            {
                db.Persons.AddRange(mappingPeople);
                db.SaveChanges();
            }
        }
    }
}

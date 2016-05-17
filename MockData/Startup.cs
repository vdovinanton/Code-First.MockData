using MockData.Source;
using MockData.Entity;

namespace CreateMockDb
{
    public class Startup
    {
        private static void Main(string[] args)
        {
            // TODO: Add Product table, with order name and order price, like this: Product.Name, Product.Price, and to tie with orders by ProductId key
            // TODO: Add gender enum and to tie with People people by one to many 

            var repository = new Repository();

            var people = Source.Instance.GetPeople();
            var orders = Source.Instance.GetOrders();
            var ordersInfo = Source.Instance.GetOrderInfo();

            var mappingOrders = repository.OrderMap(orders, ordersInfo);
            var mappingPeople = repository.PersonMap(people, mappingOrders);

            using (var db = new PersonContext())
            {
                db.Persons.AddRange(mappingPeople);

                db.SaveChanges();
            }
        }
    }
}

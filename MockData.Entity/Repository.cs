using System.Collections.Generic;
using System.Linq;
using MockData.Source.Models;

namespace MockData.Entity
{
    public class Repository
    {
        public IList<Person> PersonMap(IList<Person> people, IList<Order> orders)
        {
            foreach (var persone in people)
            {
                foreach (var order in orders.Where(order => persone.Id == order.PersonId))
                {
                    persone.Orders.Add(order);
                }
            }
            return people;
        }
    }
}

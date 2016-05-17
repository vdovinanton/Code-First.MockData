using System.Collections.Generic;
using System.Linq;
using DataSource.Models;
using MockData.Source.Models;

namespace MockData.Entity
{
    public class Repository
    {
        /// <summary>
        /// Mapping person with orders, one to many
        /// </summary>
        /// <param name="people">People collection</param>
        /// <param name="orders">Orders collection</param>
        /// <returns>Modified <see cref="Person"/></returns>
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

        /// <summary>
        /// Mapping orders with name order and price order
        /// </summary>
        /// <param name="orders">Orders without fields Name and Price</param>
        /// <param name="ordersInfo">Objects with filds Name and Price</param>
        /// <returns>Modified <see cref="Order"/></returns>
        public IList<Order> OrderMap(IList<Order> orders, IList<OrderInfo> ordersInfo)
        {
            for (var i = 0; i < orders.Count; i++)
            {
                orders[i].Name = ordersInfo[i].Name;
                orders[i].Price = ordersInfo[i].Price;
            }
            return orders;
        }
    }
}

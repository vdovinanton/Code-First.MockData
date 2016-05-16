using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateMockDb.Context.Models;

namespace Entity
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

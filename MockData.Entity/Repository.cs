using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using DataSource.Models;
using MockData.Source.Models;

namespace MockData.Entity
{
    public class Repository
    {
        private static readonly Random _rand = new Random();

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
        /// <returns>Modified <see cref="Order"/></returns>
        public IList<Order> OrderMap(IList<Order> orders, List<Product> products)
        {
            foreach (var order in orders)
            {
                var randomProduct = products[_rand.Next(products.Count)];
                order.Product = randomProduct;
            }
            return orders;
        }

        /// <summary>
        /// Mapping similar products in the single object with latest price of the similars
        /// </summary>
        /// <param name="products">Products collection</param>
        /// <returns>Modified <see cref="Product"/></returns>
        public List<Product> ProductMap(List<Product> products)
        {
            var mappingProducts = new List<Product>();

            // Select where product from products does not contain in the mapping Products
            foreach (var product in products.Where(product => mappingProducts.FirstOrDefault(q => q.Name == product.Name) == null))
            {
                mappingProducts.Add(product);
            }

            return mappingProducts;
        }
    }
}

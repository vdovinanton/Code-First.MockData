using System;
using System.Collections.Generic;
using System.IO;
using DataSource.Models;
using MockData.Source.Models;
using Newtonsoft.Json.Linq;

namespace MockData.Source
{
    public class Source
    {
        /// <summary>
        /// Initializes a instance of the <see cref="Source"/> class
        /// </summary>
        public static Source Instance => _instance.Value;

        private static readonly Lazy<Source> _instance = new Lazy<Source>(() => new Source());

        // Root folder relative directory Debug
        private string _rootFolder => $"{Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)))}\\App_Data";

        /// <summary>
        /// Read People.json and make serialization
        /// </summary>
        /// <returns>Collection <see cref="Person"/></returns>
        public IList<Person> GetPeople()
        {
            var jsonPeople = File.ReadAllText($"{_rootFolder}\\People.json");
            var people = JArray.Parse(jsonPeople).ToObject<IList<Person>>();
            return people;
        }

        /// <summary>
        /// Read Orders.json and make serialization
        /// </summary>
        /// <returns>Collection <see cref="Order"/></returns>
        public IList<Order> GetOrders()
        {
            var jsonOrders = File.ReadAllText($"{_rootFolder}\\Orders.json");
            var orders = JArray.Parse(jsonOrders).ToObject<IList<Order>>();
            return orders;
        }

        /// <summary>
        /// Read OrderInfo.json and make serialization
        /// </summary>
        /// <returns>Collection <see cref="OrderInfo"/></returns>
        public IList<OrderInfo> GetOrderInfo()
        {
            var jsonInfo = File.ReadAllText($"{_rootFolder}\\OrderInfo.json");
            var orderInfo = JArray.Parse(jsonInfo).ToObject<IList<OrderInfo>>();
            return orderInfo;
        }
    }
}

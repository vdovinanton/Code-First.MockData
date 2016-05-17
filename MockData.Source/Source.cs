using System;
using System.Collections.Generic;
using System.IO;
using MockData.Source.Models;
using Newtonsoft.Json.Linq;

namespace MockData.Source
{
    public class Source
    {
        public static Source Instance => _instance.Value;

        private static readonly Lazy<Source> _instance = new Lazy<Source>(() => new Source());

        public string RootFolder => $"{Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)))}\\App_Data";

        public IList<Person> GetPeople()
        {
            var jsonPeople = File.ReadAllText($"{RootFolder}\\People.json");
            var people = JArray.Parse(jsonPeople).ToObject<IList<Person>>();
            return people;
        }

        public IList<Order> GetOrders()
        {
            var jsonOrders = File.ReadAllText($"{RootFolder}\\Orders.json");
            var orders = JArray.Parse(jsonOrders).ToObject<IList<Order>>();
            return orders;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Models
{
    /// <summary>
    /// Represents database entity
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets products id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets product price
        /// </summary>
        public double Price { get; set; }
    }
}

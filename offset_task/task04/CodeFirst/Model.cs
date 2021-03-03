using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
        public override string ToString()
        {
            string s = FirstName + ", e-mail: " + Email;
            return s;
        }
        public virtual List<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Customer Customer { get; set; }
        public override string ToString()
        {
            string s = ProductName + " " + Quantity + "шт., дата: " + PurchaseDate;
            return s;
        }
    }
}

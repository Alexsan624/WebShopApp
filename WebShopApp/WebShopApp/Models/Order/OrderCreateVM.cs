using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

using Humanizer.Localisation.TimeToClockNotation;

namespace WebShopApp.Models.Order
{
    public class OrderCreateVM
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityInStock { get; set; }
        public string? Picture { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models.Product
{
    public class ProductPairVM
    {
        public int Id { get; set; }

        [Display(Name="Name")]
        public string Name { get; set; }
    }
}

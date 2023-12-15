using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models.Brand
{
    public class BrandPairVM
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}

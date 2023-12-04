using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopApp.Infrastructure.Data.Domain
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public virtual IEnumerable<Product> products { get; set; } = new List<Product>();
    }
}

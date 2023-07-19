using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopApplication.Models
{
    public class ProductColor
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ProductId { get; set; }
        public Color Color { get; set; }
        public Product Product { get; set; }

    }
}

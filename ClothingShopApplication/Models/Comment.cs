using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopApplication.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Content { get; set; }
        public int RatingCount { get; set; }
        public string Email { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

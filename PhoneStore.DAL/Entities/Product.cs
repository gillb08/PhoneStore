using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.DAL.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Avaliability { get; set; }
        public List<ProductImage> ProductImages { get; set;}
        public List<OrderItem> OrderItems { get; set;}
    }
}

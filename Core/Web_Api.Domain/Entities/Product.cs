using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api.Domain.Common;

namespace Web_Api.Domain.Entities
{
    public class Product:EntityBase
    {
        public required string Title { get; set; }//ürün adı
        public required string Description { get; set; }//açıklama
        public required int BrandId { get; set; }//Ürün markası id
        public Brand Brand { get; set; }//ürün marka adı
        public required decimal Price{ get; set; }//ürün fiyatı
        public required decimal Discount{ get; set; }//indirim
        public ICollection <Category> Categories { get; set; }

        
    }
}

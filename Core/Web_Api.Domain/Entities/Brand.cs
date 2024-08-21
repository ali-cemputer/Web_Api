using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api.Domain.Common;

namespace Web_Api.Domain.Entities
{
    public class Brand : EntityBase
    {
        public Brand()//marka
        {
            
        }
        public Brand(string name)
        {
            Name = name;
        }
        public required string Name { get; set; }
    }
}

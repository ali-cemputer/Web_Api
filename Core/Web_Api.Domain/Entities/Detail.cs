using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api.Domain.Common;

namespace Web_Api.Domain.Entities
{
    public class Detail:EntityBase
    {
        public Detail()
        {
            
        }
        public Detail(string title, string description)
        {
            Title = title;
            Description = description;
            
        }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int CategoryId { get; set; }
    }
}

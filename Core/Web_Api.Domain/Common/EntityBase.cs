using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Web_Api.Domain.Common
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;//tüm classları buradan türeteceğimden bu değerlerim default olarak gelmiş olacak
    }
}

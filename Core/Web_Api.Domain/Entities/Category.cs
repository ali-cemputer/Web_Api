﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Api.Domain.Common;

namespace Web_Api.Domain.Entities
{
    public class Category: EntityBase
    {
        public Category()
        {
            
        }
        public Category(int parentId, string name , int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }
        public required int ParentId { get; set; }
        public required string Name {get; set; }
        public required int Priorty { get; set; }
        public ICollection<Detail> Details { get; set; }
    }
}

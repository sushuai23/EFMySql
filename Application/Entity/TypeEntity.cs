﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity
{
    public class TypeEntity:BaseEntity
    {
        public long Id { get; set; }
        public string TypeName { get; set; }
        public string TypeDesc { get; set; }
    }
}

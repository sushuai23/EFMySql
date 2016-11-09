using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity
{
    [Table("Type")]
    public class TypeEntity:BaseEntity
    {
        public long Id { get; set; }

        public long FieldId { get; set; }

        public string TypeName { get; set; }

        public string TypeDesc { get; set; }
    }
}

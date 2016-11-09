using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity
{
    [Table("Field")]
    public class FieldEntity:BaseEntity
    {
        public long Id { get; set; }

        public string FieldName { get; set; }

        public string FieldDesc { get; set; }

    }
}

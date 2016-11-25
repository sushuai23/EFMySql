using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity
{
    [Table("TMenu")]
    public class MenuEntity:BaseEntity
    {
        public long Id { get; set; }
        public string MenuName { get; set; }
        public string MenuDesc { get; set; }
        public string MenuUrl { get; set; }

        public long ParentId { get; set; }
    }
}

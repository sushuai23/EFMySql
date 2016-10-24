using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity
{
    [Table("TUser")]
    public class UserEntity
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Desc { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entity;

namespace Application.Dao
{
    public class MysqlContext:DbContext
    {
        public MysqlContext():base("name=MySqlConnection")
        {
        }

        public virtual DbSet<UserEntity> Users { get; set; }
    }
}

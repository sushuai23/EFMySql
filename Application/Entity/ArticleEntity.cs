using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity
{
    public class ArticleEntity:BaseEntity
    {
        public long Id { get; set; }
        public long TypeId { get; set; }
    }
}

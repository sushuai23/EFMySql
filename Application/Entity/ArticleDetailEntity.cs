using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity
{
    [Table("ArticleDetail")]
    public class ArticleDetailEntity:BaseEntity
    {
        public long Id { get; set; }
        public long ArticleId { get; set; }
        public string PictureUrl { get; set; }
        public string PictureName { get; set; }
        public string PictureDesc { get; set; }
    }
}

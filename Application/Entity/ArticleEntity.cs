using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity
{
    [Table("Article")]
    public class ArticleEntity:BaseEntity
    {
        public long Id { get; set; }

        public long TypeId { get; set; }

        public string ArticleTitle { get; set; }

        public string ArticleDesc { get; set; }

        public string PictureUrl { get; set; }

        public string ArticleContent { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublichDate { get; set; }

        /// <summary>
        /// 过期时间，不设置的话，默认一直有效
        /// </summary>
        public DateTime? ExpireDate { get; set; }


        public long BrowseCount { get; set; }



    }
}

﻿using System;
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
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Desc { get; set; }

        /// <summary>
        /// 是否超级管理员
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}

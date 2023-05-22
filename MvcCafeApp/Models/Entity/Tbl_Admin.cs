using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant_Project.Models.Entity
{
    public class Tbl_Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
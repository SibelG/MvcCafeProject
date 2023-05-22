using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant_Project.Models.Entity
{
    public class Tbl_About
    {
        [Key]
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
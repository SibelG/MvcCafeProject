using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant_Project.Models.Entity
{
    public class Tbl_Why_Select
    {
        [Key]
        public int WhySelectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
using MvcCafeApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant_Project.Models.Entity
{
    public class Tbl_Menu_Foods
    {
        [Key]
        public int MenuId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Tbl_Category Category { get; set; }
    }
}
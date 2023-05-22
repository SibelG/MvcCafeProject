using Restaurant_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCafeApp.Models.Entity
{
    public class Tbl_Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<Tbl_Menu_Foods> Foods { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant_Project.Models.Entity
{
    public class Tbl_Images
    {
        [Key]
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
    }
}
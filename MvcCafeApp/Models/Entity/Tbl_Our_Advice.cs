using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant_Project.Models.Entity
{
    public class Tbl_Our_Advice
    {
        [Key]
        public int AdviceId { get; set; }
        public string Title { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Image_Address { get; set; }
    }
}
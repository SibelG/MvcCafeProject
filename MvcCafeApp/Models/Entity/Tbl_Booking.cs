using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Restaurant_Project.Models.Entity
{
    public class Tbl_Booking
    {
        [Key]
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Nullable<byte> Person_Count { get; set; }
        public string Description { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Restaurant_Project.Models.Entity
{
    public  class DataContext : DbContext
    {
        public DataContext()
            : base("name=cafeASPEntities")
        {
        }

        public  DbSet<Tbl_Login> Logins { get; set; }
        public  DbSet<Tbl_About> Abouts { get; set; }
        public  DbSet<Tbl_Menu_Foods> Menu_Foods { get; set; }
        public  DbSet<Tbl_Why_Select> Why_Selects { get; set; }
        public  DbSet<Tbl_Our_Advice> Our_Advices { get; set; }
        public  DbSet<Tbl_Images> Images { get; set; }
        public  DbSet<Tbl_Booking> Bookings { get; set; }
        public  DbSet<Tbl_Admin> Admins { get; set; }

        public System.Data.Entity.DbSet<MvcCafeApp.Models.Entity.Tbl_Category> Tbl_Category { get; set; }
    }
}
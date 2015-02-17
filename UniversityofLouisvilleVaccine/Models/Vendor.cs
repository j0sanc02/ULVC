using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityofLouisvilleVaccine.Models
{
    public class Vendor
    {
        public string vendorID { get; set; }
        public string vendorName { get; set; }
        public string vendorPhone { get; set; }
        public string vendorFax { get; set; }
        public string vendorEmail { get; set; }
        public string vendorWebsite { get; set; }
        public string vendorAddress { get; set; }

    }

    public class VendorDBContext: DbContext
    {
        public DbSet<Vendor> Vendors { get; set; }
    }
}
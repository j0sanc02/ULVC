using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityofLouisvilleVaccine.Models
{
    public class Vendor
    {
<<<<<<< HEAD
        [Key]
        [Required]
        [Display(Name = "Vendor ID")]
        public string vendorID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string vendorName { get; set; }

        [Required]
        [Display(Name = "Telephone")]
        public string vendorPhone { get; set; }

        [Required]
        [Display(Name = "Fax Number")]
        public string vendorFax { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string vendorEmail { get; set; }

        [Required]
        [Display(Name = "Website")]
        public string vendorWebsite { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string vendorAddress { get; set; }

=======
        [Display(Name = "Vendor ID:")]
        public string vendorID { get; set; }

        [Display(Name = "Vendor Name:")]
        public string vendorName { get; set; }

        [Display(Name = "Phone:")]
        public string vendorPhone { get; set; }

        [Display(Name = "Fax:")]
        public string vendorFax { get; set; }

        [Display(Name = "Email:")]
        public string vendorEmail { get; set; }

        [Display(Name = "Website:")]
        public string vendorWebsite { get; set; }

        [Display(Name = "Vendor Adddress:")]
        public string vendorAddress { get; set; }
   }

    public class VendorDBContext : DbContext
    {
        public DbSet<Vendor> Vendors { get; set; }
>>>>>>> gh-pages
    }

}
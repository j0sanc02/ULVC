﻿using System;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> gh-pages
using System.Data.Entity;

namespace UniversityofLouisvilleVaccine.Models
{
    public class Vaccine
    {
<<<<<<< HEAD

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "Please enter proper contact details.")]
=======
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
>>>>>>> gh-pages
        [Display(Name = "Vaccine ID")]
        public string vaccineID { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "Vaccine Name")]
        public string vaccineName { get; set; }

        [Required]
        [Display(Name = "Date Received")]
        [DataType(DataType.Date)]
<<<<<<< HEAD
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
=======
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
>>>>>>> gh-pages
        public DateTime dateReceived { get; set; }

        [Required]
        [Display(Name = "CPT")]
        public string CPT { get; set; }

        [Required]
        [Display(Name = "ICD-9 Code")]
        public string ICD9Code { get; set; }

        [Required]
        [Display(Name = "NDC")]
        public string NDC { get; set; }

        [Required]
        [Display(Name = "Lead Time")]
        public int leadTime { get; set; }

        [Required]
        [Display(Name = "Lot Number")]
        public string lotNumber { get; set; }

        [Required]
        [Display(Name = "Number of Doses")]
        public int numofDoses { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int salesPrice { get; set; }

<<<<<<< HEAD
        [Required]
        [Display(Name = "Expiration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime expDate { get; set; }

    }


=======
    }

    public class VaccineDBContext : DbContext
    {
        public DbSet<Vaccine> Vaccines { get; set; }
    }
>>>>>>> gh-pages

}
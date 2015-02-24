using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> gh-pages
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityofLouisvilleVaccine.Models
{
    public class VaccineUse
    {
<<<<<<< HEAD
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Vaccine Use ID")]
        public int VaccineUseId { get; set; }
=======
        [Required]
        [Display(Name = "Vaccine Use ID")]
        public string vaccineUseID { get; set; }
>>>>>>> gh-pages

        [Required]
        [Display(Name = "Vaccine ID")]
        public string vaccineID { get; set; }

        [Required]
<<<<<<< HEAD
        [Display(Name = "Lot Number")]
        public string lotNumber { get; set; }

        [Required]
=======
>>>>>>> gh-pages
        [Display(Name = "Patient ID")]
        public string patientID { get; set; }

        [Required]
<<<<<<< HEAD
        [Display(Name = "Left Arm")]
        public bool LinjectionSite { get; set; }

        [Display(Name = "Right Arm")]
        public bool RinjectionSite { get; set; }
=======
        [Display(Name = "Injection Site")]
        public string injectionSite { get; set; }
>>>>>>> gh-pages

        [Required]
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
<<<<<<< HEAD

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime VaccineUseDate { get; set; }

    }


=======
        
    }

    public class VaccineUseDBContext : DbContext
    {
        public DbSet<Vaccine> VaccineUses { get; set; }
    }



>>>>>>> gh-pages
}
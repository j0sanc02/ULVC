﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityofLouisvilleVaccine.Models
{
    public class VaccineUse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Vaccine Use ID")]
        public int VaccineUseId { get; set; }

        [Required]
        [Display(Name = "Vaccine ID")]
        public string vaccineID { get; set; }

        [Required]
        [Display(Name = "Lot Number")]
        public string lotNumber { get; set; }

        [Required]
        [Display(Name = "Patient ID")]
        public string patientID { get; set; }

        [Required]
        [Display(Name = "Left Arm")]
        public bool LinjectionSite { get; set; }

        [Display(Name = "Right Arm")]
        public bool RinjectionSite { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int quantity { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime VaccineUseDate { get; set; }

    }


}
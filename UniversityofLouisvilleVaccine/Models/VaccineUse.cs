using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityofLouisvilleVaccine.Models
{
    public class VaccineUse
    {
        [Key]
        public string VaccineUseId { get; set; }
        
        public string vaccineID { get; set; }
        
        public string lotNumber { get; set; }
        
        public string patientID { get; set; }
              
        public string injectionSite { get; set; }
        
        public int quantity { get; set; }

    }

    public class VaccineUseDBContext:DbContext
    {
        public DbSet<VaccineUse> VaccineUses { get; set; }
    }
}
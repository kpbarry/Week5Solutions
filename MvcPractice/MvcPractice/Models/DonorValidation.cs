using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.Models
{
    [MetadataType(typeof(DonorValidation))]
    public partial class Donors { }

    public class DonorValidation
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        public string MedicalReport { get; set; }
        [Required]
        public string Address { get; set; }
        [Required, Phone]
        public string ContactNumber { get; set; }
    }
}
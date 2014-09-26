using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.Models
{
    [MetadataType(typeof(PatientValidation))]
    public partial class Patients
    {
    }
    public class PatientValidation
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        [Required]
        public string Disease { get; set; }
    }
}
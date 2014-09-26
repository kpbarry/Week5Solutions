using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Step 1: Import System.ComponentModel.DataAnnotation
using System.ComponentModel.DataAnnotations;

namespace MvcPractice.Models
{
    //Step 2: Make a partial class for class we're trying to validate
    //Step 3: Add data annotation for the metadataType to the validation class
    [MetadataType(typeof(ContactFormValidation))]
    public partial class ContactForm
    {
    }

    public class ContactFormValidation
    {
        //Step 4: Declare the properties of the class you want to validate, set data annotations
        [Required]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
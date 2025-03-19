using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form.Models
{
    public class Student
    {
        [Required]
        //[RegularExpression(@"^[A-Za-z.\s-]*$")]
        [RegularExpression(@"^[a-zA-Z.\s-]*$", ErrorMessage = "Name can only contain letters, dots, dashes, and spaces.")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$", ErrorMessage = "ID: XX-XXXXX-X : 22-46078-1")]

        public string Id { get; set; }

        [Required] 
        public string Dob {  get; set; }

        [Required]
        public string Email { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotations.Models
{
    public class Person
    {
        [DisplayName("Your Name"),Required(ErrorMessage ="Please enter Name"),MinLength(5,ErrorMessage ="Enter minimum {1} characters"),MaxLength(50,ErrorMessage ="Enter maximum 50 characters")]
        public string Name { get; set; }

        [DisplayName("Your Surname"), Required(ErrorMessage ="Please Enter Surname"),StringLength(50)]
        public string Surname { get; set; }

        [DisplayName("Your Age"),Range(1,100)]
        public string Age { get; set; }

        [DisplayName("Your Email"), Required(),DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Confirm Email"), Required(), DataType(DataType.EmailAddress),Compare("Email")]
        public string ConfirmEmail { get; set; }
    }
}
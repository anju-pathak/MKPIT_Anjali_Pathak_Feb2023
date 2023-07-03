using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace validationmsg2.mvc.Models
{
    public class validation
    {
        [Required(ErrorMessage = "please enter valid name")]
        [DisplayName("enter your name")]
        [StringLength(50, MinimumLength = 3)]
        public string name { get; set; }
        [Range(1, 120, ErrorMessage = " please enter age between 1 to 120")]

        public int age { get; set; }
        [Required(ErrorMessage = "email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect EmailFormat")]


        public string email { get; set; }
        [Required(ErrorMessage = "Confirm email is Required")]
        [DataType(DataType.EmailAddress)]
        [System.ComponentModel.DataAnnotations.Compare("email", ErrorMessage = "email NotMatched")]


        public string confirmmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required (ErrorMessage="Not a valide phone number")]
        [StringLength(10)]
        //[RegularExpression(@"0-9", ErrorMessage = "Not a valide phone number")]

        public string phone { get; set; }
    }
}

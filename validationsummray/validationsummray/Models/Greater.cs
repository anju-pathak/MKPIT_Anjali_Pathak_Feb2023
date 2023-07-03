using System.ComponentModel.DataAnnotations;

namespace validationsummray.Models
{
    public class Greater
    {
        [Required(ErrorMessage = "please enter number")]
       
        public int num1 { get; set; }
        [Required(ErrorMessage = "please enter number")]
   
        public int num2 { get; set; }
      
    }
}

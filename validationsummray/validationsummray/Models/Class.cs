using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace validationsummray.Models
{
    public class Class
    {
        [Required(ErrorMessage = "please enter name")]
        public string name { get; set; }
        [Required(ErrorMessage = "enter valid number")]
        [StringLength(10)]
        public string phone { get; set; }
        [ReadOnly(true)]
        public int age { get; private set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy hh:mm:ss tt}")]
   public System.DateTime date { get; set; }
        public System.DateTime? HireDate { get; set; }
    }
}

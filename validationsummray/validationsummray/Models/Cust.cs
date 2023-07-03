using System.ComponentModel.DataAnnotations;

namespace validationsummray.Models
{
    public class Cust
    {
        [Required(ErrorMessage = "please enter number")]

        public int orderno { get; set; }
        [Required(ErrorMessage = "please enter name")]

    

        public string custname { get; set; }
        [Required(ErrorMessage = "please enter name")]
        public string productname { get; set; }
        [Required(ErrorMessage = "please enter number")]
        public int qty { get; set; }
        [Required(ErrorMessage = "please enter number")]
        public int prdprice { get; set; }
        public int res { get; set; }
    }
}

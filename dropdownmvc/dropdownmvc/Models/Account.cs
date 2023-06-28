namespace dropdownmvc.Models
{
    public class Account
    {
        public int accountno { get; set; }
        public int amount { get; set; }

        public transtype getamount { set; get; }
       
    }
    public enum transtype
    {
        deposite, withdrawl
    }
}

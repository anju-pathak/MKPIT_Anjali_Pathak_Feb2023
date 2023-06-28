namespace dropdownmvc.Models
{
    public class Customer
    {
        public int orderno { get; set; }    
        public string customername { get; set; }
        public int price { get; set; }
        public int qty { get; set; }
        public int total { get; set; }
        public prd getprd { set; get; }

    }
    public enum prd
    {
        mouse,printer,usb,keyvboard
    }
}

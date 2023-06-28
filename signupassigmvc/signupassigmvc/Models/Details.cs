using System.Runtime.InteropServices;

namespace signupassigmvc.Models
{
    public class Details
    {
        public string name { get; set; }
        public bool male{ get; set; }
        public bool female { get; set; }
        public string course { get; set; }
        public string res { get; set; }
        public City getcity { set; get; }
    }
    public enum City
    {
        Nagpur,mumbai
    }
}

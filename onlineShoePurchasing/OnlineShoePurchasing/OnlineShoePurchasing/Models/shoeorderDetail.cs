using System.ComponentModel.DataAnnotations;

namespace OnlineShoePurchasing.Models
{
    public class shoeorderDtl
    {
        [Key]
        public string orderId { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    
        public int pincode { get; set; }
        public string phoneNo { get; set; }
    }
}

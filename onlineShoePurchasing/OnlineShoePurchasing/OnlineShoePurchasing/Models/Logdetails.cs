﻿using System.ComponentModel.DataAnnotations;

namespace OnlineShoePurchasing.Models
{
    public class Logdetails
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
       
        public int id { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        
        [Column (TypeName ="nvarchar(12)")]
        public string AccountNumber { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string SWIFTCode { get; set; }
        
        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

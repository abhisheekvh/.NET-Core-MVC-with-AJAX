using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace JqueryAjax.Models
{
    public class TransactionModel
    {
        [Key]
        public int transactionId { get; set; }
        [Column(TypeName ="nvarchar(12)")]
        [Required(ErrorMessage ="Account number is empty!")]
        [Display(Name ="Account Number")]
        public string accountNumber { get; set; }

        [Column(TypeName ="nvarchar(100)")]
         [Display(Name ="Benificiary Name")]
         [Required(ErrorMessage ="Name is empty!")]
        public string BenificiaryName { get; set; }

        [Column(TypeName ="nvarchar(100)")]
         [Display(Name ="Bank Name")]
         [Required(ErrorMessage ="Bank Name is empty!")]
        public string bankName { get; set; }

        [Column(TypeName ="nvarchar(100)")]
         [Display(Name ="Swift Code")]
         [Required(ErrorMessage ="Swift Code is empty!")]
        public string swiftCode { get; set; }

       [Display(Name ="Amount")]
       [Required(ErrorMessage ="Amount is empty!")]
        public int amount { get; set; }


        public DateTime Date{get;set;}
    }
}
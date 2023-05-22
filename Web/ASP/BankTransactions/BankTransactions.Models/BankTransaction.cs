using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    [Table("bank_transactions")]
    public class BankTransaction
    {
        [Key]
        [Column("transaction_id")]
        public int Transaction_Id { get; set; }

        [Required]
        [Column("transaction_date")]
        public DateTime Transaction_Date { get; set; }

        [Required]
        [Column("transaction_from")]
        [Range(10000000000, 99999999999)]
        public long Transaction_From { get; set; }

        [Required]
        [Column("transaction_to")]
        [Range(10000000000, 99999999999)]
        public long Transaction_To { get; set; }

        [Required]
        [Column("transaction_amount")]
        [Range(0.01, 99000)]
        [Precision(7,2)]
        public decimal Transaction_Amount { get; set; }


        public bool UpdateFromAnotherTransactionInstance(BankTransaction transaction)
        {
            this.Transaction_Amount = transaction.Transaction_Amount;
            this.Transaction_Date = transaction.Transaction_Date;
            this.Transaction_From = transaction.Transaction_From;
            this.Transaction_To = transaction.Transaction_To;
            return true;
        }

    }
}
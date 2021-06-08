using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("account")]
    public class Account
    {
        [Column("account_id")]
        public Guid Id { get; set; }

        [Column("date_created")]
        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

        [Column("account_type")]
        [Required(ErrorMessage = "Account type is required")]
        public string AccountType { get; set; }

        [Column("owner_id")]
        [ForeignKey(nameof(Owner))]
        public Guid OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
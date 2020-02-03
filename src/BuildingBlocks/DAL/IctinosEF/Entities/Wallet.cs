using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IctinosEF.Entities
{
    [Table("wallet")]

    public class Wallet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public virtual User User { get; set; }

        public virtual ICollection<Coin> Coins { get; set; }

        public Guid UserId { get; set; }
    }
}

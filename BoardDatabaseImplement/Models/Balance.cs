using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BoardDatabaseImplement.Models
{
    public class Balance
    {
        public int Id { get; set; }
        [Required]
        public double Money { get; set; }
        [Required]
        public double MoneySpent { get; set; }
        [Required]
        public string CardNumb { get; set; }
        [Required]
        public string CardFIO { get; set; }
        [Required]
        public string CardDate { get; set; }
        public int UserId { get; set; }
        public virtual Users User { get; set; }
    }
}

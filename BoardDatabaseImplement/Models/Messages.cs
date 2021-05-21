using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BoardDatabaseImplement.Models
{
    public class Messages
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int UserId { get; set; }
        public virtual Users User { get; set; }
    }
}

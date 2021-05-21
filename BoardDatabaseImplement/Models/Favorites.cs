using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BoardDatabaseImplement.Models
{
    public class Favorites
    {
        public int Id { get; set; }
        [Required]
        public string AdName { get; set; }
        [Required]
        public string Link { get; set; }
        public int UserId { get; set; }
        public virtual Users User { get; set; }
    }
}

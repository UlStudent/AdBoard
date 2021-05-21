using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BoardDatabaseImplement.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
        [Required]
        public bool IsVerificated { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BindingModels
{
    public class UsersBindingModel
    {
        public int? Id { get; set; }
        public string Username { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsVerificated { get; set; }
    }
}

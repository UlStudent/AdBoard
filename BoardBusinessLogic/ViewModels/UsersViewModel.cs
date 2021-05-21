using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BoardBusinessLogic.ViewModels
{
    public class UsersViewModel
    {
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string Username { get; set; }
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [DisplayName("Номер телефона")]
        public string Phone { get; set; }
        [DisplayName("Админ?")]
        public bool IsAdmin { get; set; }
        [DisplayName("Проверенный?")]
        public bool IsVerificated { get; set; }
    }
}

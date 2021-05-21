using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BoardBusinessLogic.ViewModels
{
    public class MessagesViewModel
    {
        public int Id { get; set; }
        [DisplayName("Текст сообщения")]
        public string Text { get; set; }
        [DisplayName("Дата отправки")]
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        [DisplayName("Имя пользователя")]
        public string Username { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BoardBusinessLogic.ViewModels
{
    public class FavoriteViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название объявления")]
        public string AdName { get; set; }
        [DisplayName("Ссылка на объявление")]
        public string Link { get; set; }
        public int UserId { get; set; }
        [DisplayName("Имя пользователя")]
        public string Username { get; set; }
    }
}
 
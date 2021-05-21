using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BoardBusinessLogic.ViewModels
{
    public class AdViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название  ")]
        public string Name { get; set; }
        [DisplayName("Цена")]
        public double Price { get; set; }
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        [DisplayName("Адрес")]
        public string Address { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Категория")]
        public string Type { get; set; }
        [DisplayName("Подкатегория")]
        public string SubType { get; set; }
        public int UserId { get; set; }
        [DisplayName("Имя пользователя")]
        public string Username { get; set; }
    }
}
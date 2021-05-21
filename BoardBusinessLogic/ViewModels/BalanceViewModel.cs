using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BoardBusinessLogic.ViewModels
{
    public class BalanceViewModel
    {
        public int Id { get; set; }
        [DisplayName("Кол-во денег")]
        public double Money { get; set; }
        [DisplayName("Кол-во потраченных денег")]
        public double MoneySpent { get; set; }
        [DisplayName("Номер карты")]
        public string CardNumb { get; set; }
        [DisplayName("ФИО держателя")]
        public string CardFIO { get; set; }
        [DisplayName("Дата исхода срока")]
        public string CardDate { get; set; }
        public int UserId { get; set; }
        [DisplayName("Имя пользователя")]
        public string Username { get; set; }
    }
}

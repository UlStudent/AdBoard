using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BindingModels
{
    public class BalanceBindingModel
    {
        public int Id { get; set; }
        public double Money { get; set; }
        public double MoneySpent { get; set; }
        public string CardNumb { get; set; }
        public string CardFIO { get; set; }
        public string CardDate { get; set; }
        public int UserId { get; set; }
    }
}

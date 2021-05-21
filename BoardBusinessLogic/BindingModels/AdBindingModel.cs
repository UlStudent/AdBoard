using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BindingModels
{
    public class AdBindingModel
    {
        private int? Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public int UserId { get; set; }
    }
}

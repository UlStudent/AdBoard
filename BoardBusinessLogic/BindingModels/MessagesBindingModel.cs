using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BindingModels
{
    public class MessagesBindingModel
    {
        public int? Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int? UserId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BindingModels
{
    public class FavoriteBindingModel
    {
        public int? Id { get; set; }
        public string AdName { get; set; }
        public string Link { get; set; }
        public int? UserId { get; set; }
    }
}

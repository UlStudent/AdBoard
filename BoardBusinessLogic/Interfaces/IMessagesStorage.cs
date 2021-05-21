using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.Interfaces
{
    public interface IMessagesStorage
    {
        List<MessagesViewModel> GetFullList();

        List<MessagesViewModel> GetFilteredList(MessagesBindingModel model);

        MessagesViewModel GetElement(MessagesBindingModel model);

        void Insert(MessagesBindingModel model);

        void Update(MessagesBindingModel model);

        void Delete(MessagesBindingModel model);
    }
}

using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.Interfaces;
using BoardBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BusinessLogic
{
    public class MessagesLogic
    {
        private readonly IMessagesStorage _messageStorage;

        public MessagesLogic(IMessagesStorage messageStorage)
        {
            _messageStorage = messageStorage;
        }

        public List<MessagesViewModel> Read(MessagesBindingModel model)
        {
            if (model == null)
            {
                return _messageStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<MessagesViewModel> { _messageStorage.GetElement(model) };
            }
            return _messageStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(MessagesBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _messageStorage.Update(model);
            }
            else
            {
                _messageStorage.Insert(model);
            }
        }
        public void Delete(MessagesBindingModel model)
        {
            var element = _messageStorage.GetElement(new MessagesBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Сообщение не найден");
            }
            _messageStorage.Delete(model);
        }
    }
}

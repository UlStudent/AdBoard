﻿using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.Interfaces;
using BoardBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BusinessLogic
{
    public class MessageLogic
    {
        private readonly IMessageStorage _messageStorage;

        public MessageLogic(IMessageStorage messageStorage)
        {
            _messageStorage = messageStorage;
        }

        public List<MessageViewModel> Read(MessageBindingModel model)
        {
            if (model == null)
            {
                return _messageStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<MessageViewModel> { _messageStorage.GetElement(model) };
            }
            return _messageStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(MessageBindingModel model)
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
        public void Delete(MessageBindingModel model)
        {
            var element = _messageStorage.GetElement(new MessageBindingModel
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

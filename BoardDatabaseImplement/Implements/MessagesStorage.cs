using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.Interfaces;
using BoardBusinessLogic.ViewModels;
using BoardDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardDatabaseImplement.Implements
{
    public class MessagesStorage : IMessagesStorage
    {
        public List<MessagesViewModel> GetFullList()
        {
            using (var context = new AdBoardDatabase())
            {
                return context.Messages.Include(rec => rec.User).Select(rec => new MessagesViewModel
                {
                    Id = rec.Id,
                    Username = context.Messages.Include(x => x.User).FirstOrDefault(x => x.UserId == rec.UserId).User.Username,
                    UserId = rec.UserId,
                    Text = rec.Text,
                    Date = rec.Date
                })
                .ToList();
            }
        }

        public List<MessagesViewModel> GetFilteredList(MessagesBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new AdBoardDatabase())
            {
                return context.Messages
                .Include(rec => rec.User)
                .Where(rec => rec.UserId == model.UserId)
                .Select(rec => new MessagesViewModel
                {
                    Id = rec.Id,
                    Username = rec.User.Username,
                    UserId = rec.UserId,
                    Text = rec.Text,
                    Date = rec.Date
                })
                .ToList();
            }
        }

        public MessagesViewModel GetElement(MessagesBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new AdBoardDatabase())
            {
                var message = context.Messages
                .FirstOrDefault(rec =>rec.Id == model.Id);
                return message != null ?
                new MessagesViewModel
                {
                    Id = message.Id,
                    Username = context.Messages.Include(x => x.User).FirstOrDefault(x => x.UserId == x.UserId).User.Username,
                    UserId = message.UserId,
                    Text = message.Text,
                    Date = message.Date
                } :
                null;
            }
        }

        public void Insert(MessagesBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                context.Messages.Add(CreateModel(model, new Messages()));
                context.SaveChanges();
            }
        }

        public void Update(MessagesBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                var element = context.Messages.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element == null)
                {
                    throw new Exception("Сообщение не найдено");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(MessagesBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                Messages element = context.Messages.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element != null)
                {
                    context.Messages.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Сообщение не найдено");
                }
            }
        }

        private Messages CreateModel(MessagesBindingModel model, Messages message)
        {
            message.Text = model.Text;
            message.Date = model.Date;
            return message;
        }
    }
}

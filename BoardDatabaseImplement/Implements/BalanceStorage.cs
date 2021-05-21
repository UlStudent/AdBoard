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
    public class BalanceStorage : IBalanceStorage
    {
        public List<BalanceViewModel> GetFullList()
        {
            using (var context = new AdBoardDatabase())
            {
                return context.Balance.Select(rec => new BalanceViewModel
                {
                    Id = rec.Id,
                    CardFIO = rec.CardFIO,
                    Username = context.Messages.Include(x => x.User).FirstOrDefault(x => x.UserId == x.UserId).User.Username,
                    CardNumb = rec.CardFIO,
                    CardDate = rec.CardFIO,
                })
                .ToList();
            }
        }

        public List<BalanceViewModel> GetFilteredList(BalanceBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new AdBoardDatabase())
            {
                return context.Balance
                .Select(rec => new BalanceViewModel
                {
                    Id = rec.Id,
                    CardFIO = rec.CardFIO,
                    Username = rec.User.Username,
                    CardNumb = rec.CardFIO,
                    CardDate = rec.CardFIO,
                })
                .ToList();
            }
        }

        public BalanceViewModel GetElement(BalanceBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new AdBoardDatabase())
            {
                var user = context.Balance
                .FirstOrDefault(rec => rec.Id == model.Id);
                return user != null ?
                new BalanceViewModel
                {
                    Id = rec.Id,
                    CardFIO = rec.CardFIO,
                    Username = rec.User.Username,
                    CardNumb = rec.CardFIO,
                    CardDate = rec.CardFIO,
                } :
                null;
            }
        }

        public void Insert(BalanceBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                context.Balance.Add(CreateModel(model, new Balance()));
                context.SaveChanges();
            }
        }

        public void Update(BalanceBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                var element = context.Balance.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element == null)
                {
                    throw new Exception("Баланс не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(BalanceBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                Balance element = context.Balance.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element != null)
                {
                    context.Balance.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Клиент не найден");
                }
            }
        }

        private Balance CreateModel(BalanceBindingModel model, Balance balance)
        {
            model.Id = balance.Id;
            model.CardFIO = balance.CardFIO;
            model.Username = balance.User.Username;
            model.CardNumb = balance.CardFIO;
            model. CardDate = balance.CardFIO;
            return balance;
        }
    }
}

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
    public class AdStorage : IAdStorage
    {
        public List<AdViewModel> GetFullList()
        {
            using (var context = new AdBoardDatabase())
            {
                return context.Ads.Select(rec => new AdViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Username = context.Messages.Include(x => x.User).FirstOrDefault(x => x.UserId == x.UserId).User.Username,
                    Price = rec.Price,
                    Date = rec.Date,
                    Address = rec.Address,
                    Description = rec.Description,
                    Type = rec.Type,
                    SubType = rec.SubType,
                    UserId = rec.UserId
                })
                .ToList();
            }
        }

        public List<AdViewModel> GetFilteredList(AdBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new AdBoardDatabase())
            {
                return context.Ads
                .Select(rec => new AdViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Username = rec.User.Username,
                    Price = rec.Price,
                    Date = rec.Date,
                    Address = rec.Address,
                    Description = rec.Description,
                    Type = rec.Type,
                    SubType = rec.SubType,
                    UserId = rec.UserId
                })
                .ToList();
            }
        }

        public AdViewModel GetElement(AdBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new AdBoardDatabase())
            {
                var user = context.Ads
                .FirstOrDefault(rec => rec.Id == model.Id);
                return user != null ?
                new AdViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    Username = rec.User.Username,
                    Price = rec.Price,
                    Date = rec.Date,
                    Address = rec.Address,
                    Description = rec.Description,
                    Type = rec.Type,
                    SubType = rec.SubType,
                    UserId = rec.UserId
                } :
                null;
            }
        }

        public void Insert(AdBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                context.Ads.Add(CreateModel(model, new Ad()));
                context.SaveChanges();
            }
        }

        public void Update(AdBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                var element = context.Ads.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element == null)
                {
                    throw new Exception("Баланс не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(AdBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                Ad element = context.Ads.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element != null)
                {
                    context.Ads.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Клиент не найден");
                }
            }
        }
        private Ad CreateModel(AdBindingModel model, Ad ad)
        {
            ad.Id = model.Id;
            ad.Name = model.Name;
            ad.Price = model.Price;
            ad.Date = model.Date;
            ad.Address = model.Address;
            ad.Description = model.Description;
            ad.Type = model.Type;
            ad.SubType = model.SubType;
            ad.UserId = model.UserId;
            return ad;
        }
    }
}

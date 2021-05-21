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
    class FavoritesStorage : IFavoritesStorage
    {
        public List<FavoritesViewModel> GetFullList()
        {
            using (var context = new AdBoardDatabase())
            {
                return context.Favorites.Include(rec => rec.User).Select(rec => new FavoritesViewModel
                {
                    Id = rec.Id,
                    Username = context.Favorites.Include(x => x.User).FirstOrDefault(x => x.UserId == rec.UserId).User.Username,
                    UserId = rec.UserId,
                    AdName = rec.AdName,
                    Link = rec.Link
                })
                .ToList();
            }
        }

        public List<FavoritesViewModel> GetFilteredList(FavoritesBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new AdBoardDatabase())
            {
                return context.Favorites
                .Include(rec => rec.User)
                .Where(rec => rec.UserId == model.UserId)
                .Select(rec => new FavoritesViewModel
                {
                    Id = rec.Id,
                    Username = context.Favorites.Include(x => x.User).FirstOrDefault(x => x.UserId == rec.UserId).User.Username,
                    UserId = rec.UserId,
                    AdName = rec.AdName,
                    Link = rec.Link
                })
                .ToList();
            }
        }

        public FavoritesViewModel GetElement(FavoritesBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new AdBoardDatabase())
            {
                var message = context.Favorites
                .FirstOrDefault(rec => rec.Id == model.Id);
                return message != null ?
                new FavoritesViewModel
                {
                    Id = rec.Id,
                    Username = context.Favorites.Include(x => x.User).FirstOrDefault(x => x.UserId == rec.UserId).User.Username,
                    UserId = rec.UserId,
                    AdName = rec.AdName,
                    Link = rec.Link
                } :
                null;
            }
        }

        public void Insert(FavoritesBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                context.Favorites.Add(CreateModel(model, new Favorites()));
                context.SaveChanges();
            }
        }

        public void Update(FavoritesBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                var element = context.Favorites.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element == null)
                {
                    throw new Exception("Сообщение не найдено");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(FavoritesBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                Favorites element = context.Favorites.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element != null)
                {
                    context.Favorites.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Сообщение не найдено");
                }
            }
        }

        private Favorites CreateModel(FavoritesBindingModel model, Favorites favorite)
        {
            favorite.Link = model.Link;
            favorite.AdName = model.AdName;
            return favorite;
        }
    }
}

using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.Interfaces;
using BoardBusinessLogic.ViewModels;
using BoardDatabaseImplement;
using BoardDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoardImplement.Implements
{
    public class UsersStorage : IUsersStorage
    {
        public List<UsersViewModel> GetFullList()
        {
            using (var context = new AdBoardDatabase())
            {
                return context.Users.Select(rec => new UsersViewModel
                {
                    Id = rec.Id,
                    Username = rec.Username,
                    Login = rec.Login,
                    Password = rec.Password,
                    Phone = rec.Phone,
                    IsAdmin = rec.IsAdmin,
                    IsVerificated = rec.IsVerificated
                })
                .ToList();
            }
        }

        public List<UsersViewModel> GetFilteredList(UsersBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new AdBoardDatabase())
            {
                return context.Users
                .Where(rec => rec.Login == model.Login && rec.Password == model.Password)
                .Select(rec => new UsersViewModel
                {
                    Id = rec.Id,
                    Username = rec.Username,
                    Login = rec.Login,
                    Password = rec.Password,
                    Phone = rec.Phone,
                    IsAdmin = rec.IsAdmin,
                    IsVerificated = rec.IsVerificated
                })
                .ToList();
            }
        }

        public UsersViewModel GetElement(UsersBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new AdBoardDatabase())
            {
                var user = context.Users
                .FirstOrDefault(rec => rec.Login == model.Login || rec.Id == model.Id);
                return user != null ?
                new UsersViewModel
                {
                    Id = user.Id,
                    Username = user.Username,
                    Login = user.Login,
                    Password = user.Password,
                    Phone = user.Phone,
                    IsAdmin = user.IsAdmin,
                    IsVerificated = user.IsVerificated
                } :
                null;
            }
        }

        public void Insert(UsersBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                context.Users.Add(CreateModel(model, new Users()));
                context.SaveChanges();
            }
        }

        public void Update(UsersBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                var element = context.Users.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element == null)
                {
                    throw new Exception("Клиент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(UsersBindingModel model)
        {
            using (var context = new AdBoardDatabase())
            {
                Users element = context.Users.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element != null)
                {
                    context.Users.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Клиент не найден");
                }
            }
        }

        private Users CreateModel(UsersBindingModel model, Users user)
        {
            user.Username = model.Username;
            user.Login = model.Login;
            user.Password = model.Password;
            user.Phone = model.Phone;
            user.IsAdmin = model.IsAdmin;
            user.IsVerificated = model.IsVerificated;
            return user;
        }
    }
}

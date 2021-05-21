using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.Interfaces;
using BoardBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BusinessLogic
{
    public class FavoritesLogic
    {
        private readonly IFavoritesStorage _favoriteStorage;

        public FavoritesLogic(IFavoritesStorage favoriteStorage)
        {
            _favoriteStorage = favoriteStorage;
        }

        public List<FavoritesViewModel> Read(FavoritesBindingModel model)
        {
            if (model == null)
            {
                return _favoriteStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<FavoritesViewModel> { _favoriteStorage.GetElement(model) };
            }
            return _favoriteStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(FavoritesBindingModel model)
        {
            var element = _favoriteStorage.GetElement(new FavoritesBindingModel
            {
                Link = model.Link
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть такое избранное");
            }
            if (model.Id.HasValue)
            {
                _favoriteStorage.Update(model);
            }
            else
            {
                _favoriteStorage.Insert(model);
            }
        }
        public void Delete(FavoritesBindingModel model)
        {
            var element = _favoriteStorage.GetElement(new FavoritesBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Избранное не найдено");
            }
            _favoriteStorage.Delete(model);
        }
    }
}

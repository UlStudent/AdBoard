using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.Interfaces;
using BoardBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BusinessLogic
{
    public class FavoriteLogic
    {
        private readonly IFavoriteStorage _favoriteStorage;

        public FavoriteLogic(IFavoriteStorage favoriteStorage)
        {
            _favoriteStorage = favoriteStorage;
        }

        public List<FavoriteViewModel> Read(FavoriteBindingModel model)
        {
            if (model == null)
            {
                return _favoriteStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<FavoriteViewModel> { _favoriteStorage.GetElement(model) };
            }
            return _favoriteStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(FavoriteBindingModel model)
        {
            var element = _favoriteStorage.GetElement(new FavoriteBindingModel
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
        public void Delete(FavoriteBindingModel model)
        {
            var element = _favoriteStorage.GetElement(new FavoriteBindingModel
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

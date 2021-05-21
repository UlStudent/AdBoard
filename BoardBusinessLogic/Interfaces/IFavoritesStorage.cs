using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BoardBusinessLogic.Interfaces
{
    public interface IFavoritesStorage
    {
        List<FavoritesViewModel> GetFullList();

        List<FavoritesViewModel> GetFilteredList(FavoritesBindingModel model);

        FavoritesViewModel GetElement(FavoritesBindingModel model);

        void Insert(FavoritesBindingModel model);

        void Update(FavoritesBindingModel model);

        void Delete(FavoritesBindingModel model);
    }
}

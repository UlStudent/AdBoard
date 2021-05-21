using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BoardBusinessLogic.Interfaces
{
    public interface IFavoriteStorage
    {
        List<FavoriteViewModel> GetFullList();

        List<FavoriteViewModel> GetFilteredList(FavoriteBindingModel model);

        FavoriteViewModel GetElement(FavoriteBindingModel model);

        void Insert(FavoriteBindingModel model);

        void Update(FavoriteBindingModel model);

        void Delete(FavoriteBindingModel model);
    }
}

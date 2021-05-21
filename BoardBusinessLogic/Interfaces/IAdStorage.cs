using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.Interfaces
{
    public interface IAdStorage
    {
        List<AdViewModel> GetFullList();

        List<AdViewModel> GetFilteredList(AdBindingModel model);

        AdViewModel GetElement(AdBindingModel model);

        void Insert(AdBindingModel model);

        void Update(AdBindingModel model);

        void Delete(AdBindingModel model);
    }
}

using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.Interfaces
{
    public interface IBalanceStorage
    {
        List<BalanceViewModel> GetFullList();

        List<BalanceViewModel> GetFilteredList(BalanceBindingModel model);

        BalanceViewModel GetElement(BalanceBindingModel model);

        void Insert(BalanceBindingModel model);

        void Update(BalanceBindingModel model);

        void Delete(BalanceBindingModel model);
    }
}

using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.Interfaces;
using BoardBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BusinessLogic
{
    public class BalanceLogic
    {
        private readonly IBalanceStorage _balanceStorage;

        public BalanceLogic(IBalanceStorage balanceStorage)
        {
            _balanceStorage = balanceStorage;
        }

        public List<BalanceViewModel> Read(BalanceBindingModel model)
        {
            if (model == null)
            {
                return _balanceStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<BalanceViewModel> { _balanceStorage.GetElement(model) };
            }
            return _balanceStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(BalanceBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _balanceStorage.Update(model);
            }
            else
            {
                _balanceStorage.Insert(model);
            }
        }
        public void Delete(BalanceBindingModel model)
        {
            var element = _balanceStorage.GetElement(new BalanceBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Баланс не найден");
            }
            _balanceStorage.Delete(model);
        }
    }
}

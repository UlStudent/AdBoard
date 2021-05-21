using BoardBusinessLogic.BindingModels;
using BoardBusinessLogic.Interfaces;
using BoardBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardBusinessLogic.BusinessLogic
{
    public class AdLogic
    {
        private readonly IAdStorage _adStorage;

        public AdLogic(IAdStorage adStorage)
        {
            _adStorage = adStorage;
        }

        public List<AdViewModel> Read(AdBindingModel model)
        {
            if (model == null)
            {
                return _adStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<AdViewModel> { _adStorage.GetElement(model) };
            }
            return _adStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(AdBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _adStorage.Update(model);
            }
            else
            {
                _adStorage.Insert(model);
            }
        }
        public void Delete(AdBindingModel model)
        {
            var element = _adStorage.GetElement(new AdBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Объявление не найдено");
            }
            _adStorage.Delete(model);
        }
    }
}

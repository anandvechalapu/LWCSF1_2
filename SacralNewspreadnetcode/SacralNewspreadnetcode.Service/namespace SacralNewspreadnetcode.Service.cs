using System;
using SacralNewspreadnetcode.DTO;
using SacralNewspreadnetcode.DataAccess;

namespace SacralNewspreadnetcode.Service
{
    public class PriceChangesService
    {
        private PriceChangesRepository _priceChangesRepository;

        public PriceChangesService()
        {
            _priceChangesRepository = new PriceChangesRepository();
        }

        public PriceChanges GetPriceChangesById(int id)
        {
            return _priceChangesRepository.GetPriceChangesById(id);
        }

        public void CreatePriceChanges(PriceChanges priceChanges)
        {
            _priceChangesRepository.CreatePriceChanges(priceChanges);
        }

        public void UpdatePriceChanges(PriceChanges priceChanges)
        {
            _priceChangesRepository.UpdatePriceChanges(priceChanges);
        }

        public void DeletePriceChanges(int id)
        {
            _priceChangesRepository.DeletePriceChanges(id);
        }
    }
}
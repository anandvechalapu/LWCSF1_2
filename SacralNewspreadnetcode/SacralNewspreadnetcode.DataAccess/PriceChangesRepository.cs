using System;
using SacralNewspreadnetcode.DTO;

namespace SacralNewspreadnetcode
{
    public class PriceChangesRepository
    {
        public PriceChanges GetPriceChangesById(int id)
        {
            PriceChanges priceChanges = new PriceChanges();

            // Retrieve the price changes from the data source.

            return priceChanges;
        }

        public void CreatePriceChanges(PriceChanges priceChanges)
        {
            // Save the price changes to the data source.
        }

        public void UpdatePriceChanges(PriceChanges priceChanges)
        {
            // Update the price changes in the data source.
        }

        public void DeletePriceChanges(int id)
        {
            // Remove the price changes from the data source.
        }
    }
}
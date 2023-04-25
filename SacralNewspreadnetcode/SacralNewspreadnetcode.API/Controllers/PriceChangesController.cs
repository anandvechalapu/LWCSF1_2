using System;
using SacralNewspreadnetcode.DTO;
using SacralNewspreadnetcode.Service;
using Microsoft.AspNetCore.Mvc;

namespace SacralNewspreadnetcode.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceChangesController : ControllerBase
    {
        private PriceChangesService _priceChangesService;

        public PriceChangesController()
        {
            _priceChangesService = new PriceChangesService();
        }

        [HttpGet("{id}")]
        public PriceChanges GetPriceChangesById(int id)
        {
            return _priceChangesService.GetPriceChangesById(id);
        }

        [HttpPost]
        public void CreatePriceChanges([FromBody] PriceChanges priceChanges)
        {
            _priceChangesService.CreatePriceChanges(priceChanges);
        }

        [HttpPut("{id}")]
        public void UpdatePriceChanges(int id, [FromBody] PriceChanges priceChanges)
        {
            _priceChangesService.UpdatePriceChanges(priceChanges);
        }

        [HttpDelete("{id}")]
        public void DeletePriceChanges(int id)
        {
            _priceChangesService.DeletePriceChanges(id);
        }
    }
}
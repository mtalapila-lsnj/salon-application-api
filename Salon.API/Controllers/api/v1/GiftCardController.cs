using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Salon.Domain;
using Salon.Service.Interfaces;

namespace Salon.API.Controllers.api.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftCardController : ControllerBase
    {
        private readonly IGiftCardService _giftCardService;
        public GiftCardController(IGiftCardService giftCardService)
        {
            _giftCardService = giftCardService;
        }        
        [HttpGet]
        public ActionResult<IEnumerable<GiftCardViewModel>> Get()
        {
            var giftCards = _giftCardService.GetGiftCards();
            return Ok(giftCards);
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var giftCard = _giftCardService.GetGiftCard(id);
            return Ok(giftCard);
        }
        [HttpPost]
        public ActionResult<GiftCardViewModel> Post(GiftCardViewModel giftCard)
        {
            try
            {
                var gc = _giftCardService.AddGiftCard(giftCard);
                return Ok(gc);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }            
        }
    }
}
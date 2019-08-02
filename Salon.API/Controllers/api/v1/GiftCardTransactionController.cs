﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Salon.Data.Entities;
using Salon.Domain;
using Salon.Service.Interfaces;

namespace Salon.API.Controllers.api.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftCardTransactionController : ControllerBase
    {
        private readonly IGiftCardTransactionService _giftCardTransactionService;
        public GiftCardTransactionController(IGiftCardTransactionService giftCardTransactionService)
        {
            _giftCardTransactionService = giftCardTransactionService;
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<GiftCardTransactionViewModel> GetTransactionById(int id)
        {
            var transaction = _giftCardTransactionService.GetGiftCardTransactionById(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return Ok(transaction);
        }
        [HttpGet]
        [Route("giftcard/{id}")]
        public ActionResult<IEnumerable<GiftCardTransactionViewModel>> GetTransactionsByGiftCardId(int id)
        {
            var transactions = _giftCardTransactionService.GetTransactionsByGiftCardId(id);
            if (transactions.Count() <= 0)
                return NotFound();
            return Ok(transactions);
        }
        [HttpPost]
        [Route("addtransaction")]
        public ActionResult<GiftCardTransaction> AddTransactionForGiftCard(GiftCardTransactionViewModel transaction)
        {
            if (transaction.GiftCard == null)
            {
                return BadRequest();
            }
            var trans = _giftCardTransactionService.CreateTransactionForGiftCard(transaction);
            return Ok(trans);
        }

    }
}
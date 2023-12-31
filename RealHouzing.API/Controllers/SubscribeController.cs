﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHouzing.DtoLayer.SubscribeDtos;
using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;

namespace RealHozing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddSubscribe(AddSubscribeDto p)
        {
            Subscribe subscribe = new Subscribe()
            {
                Mail = p.Mail
            };
            _subscribeService.TInsert(subscribe);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult PutSubscribe(UpdateSubscribeDto p)
        {
            Subscribe sub = new Subscribe()
            {
                Mail = p.Mail,
                SubscribeID = p.SubscribeID
            };
            _subscribeService.TUpdate(sub);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            _subscribeService.TDelete(values);
            return Ok();
        }
    }
}
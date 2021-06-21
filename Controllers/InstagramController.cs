using HRMoneyAPI.Models;
using HRMoneyAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRMoneyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstagramController : Controller
    {
        private readonly InstagramService _instagramService;

        public InstagramController(InstagramService instagramService)
        {
            _instagramService = instagramService;
        }

        //[HttpGet]
        //public ActionResult<List<Instagram>> Get() => _instagramService.Get();

        [HttpGet("{conta}:{token}", Name = "GetInstagram")]
        public ActionResult<Instagram> Get(string conta, string token)
        {
            var instagram = _instagramService.Get(conta, token);

            if (instagram == null)
                return NotFound();

            return instagram;
        }

        [HttpGet("{token}", Name = "GetAllInstagram")]
        public ActionResult<List<Instagram>> GetAll(string token)
        {
            var instagram = _instagramService.GetAll(token);

            if (instagram == null)
                return NotFound();

            return instagram;
        }

        [HttpPost ("{token}", Name = "Vincular Instagram Account")]
        public ActionResult<Instagram> Create(string token, Instagram instagram)
        {
            if (instagram.Conta != null && instagram.Senha != null && instagram.Token != null)
            {
                if (_instagramService.Create(instagram) != null)
                {
                    return instagram;
                }
                return NoContent();
            }
            return NotFound();
        }

        [HttpPut("{conta}:{token}")]
        public ActionResult<Instagram> Update(string conta, string token, Instagram instagramIn)
        {
            var instagram = _instagramService.Get(conta, token);

            if (instagram == null)
                return NotFound();
            instagramIn.Id = instagram.Id;
            _instagramService.Update(conta, instagramIn);

            return instagramIn;
        }

        [HttpDelete("{conta}:{token}")]
        public ActionResult<string> Delete(string conta, string token)
        {
            var instagram = _instagramService.Get(conta, token);

            if (instagram == null)
                return NotFound();

            _instagramService.Remove(instagram.Conta);

            return "Conta deletada";
        }
    }
}
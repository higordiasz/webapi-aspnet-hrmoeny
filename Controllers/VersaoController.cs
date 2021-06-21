using HRMoneyAPI.Models;
using HRMoneyAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRMoneyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersaoController : Controller
    {
        private readonly VersaoService _versaoService;

        public VersaoController(VersaoService versaoService)
        {
            _versaoService = versaoService;
        }

        [HttpGet]
        public ActionResult<Versao> Get() => _versaoService.Get();

        [HttpPut("{token}:{hrconfig}:{hrganhar}:{hrsiga}:{hrkzom}:{hrdizu}:{hrfarma}:{hrbroad}:{hreverve}")]
        public void Put(string token, string HRConfig, string HRganhar, string HRSiga, string HRKzom, string HRDizu, string HRFarma, string HRbroad, string HREverve) {
            if (token == "")
            {
                Versao aux = new Versao();
                aux.HRConfig = HRConfig;
                aux.HRGanhar = HRganhar;
                aux.HRSiga = HRSiga;
                aux.HRKzom = HRKzom;
                aux.HRDizu = HRDizu;
                aux.HRFarma = HRFarma;
                aux.HRBroad = HRbroad;
                aux.HREverze = HREverve;
                _versaoService.Put(aux);
            }
        }
    }
}
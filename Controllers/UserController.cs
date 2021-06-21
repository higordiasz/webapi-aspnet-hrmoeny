using HRMoneyAPI.Models;
using HRMoneyAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB;
using HRMoneyAPI.Criptografia;

namespace HRMoneyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}:{senha}", Name = "Buscar Usuario")]
        public ActionResult<User> Get(string email, string senha)
        {
            var user = _userService.Login(email, senha);

            if (user == null)
                return NotFound();

            return user;
        }

        [HttpPost ("{email}:{senha}", Name = "Criar Conta")]
        public string Create(string email, string senha)
        {
            string retorno = _userService.Create(email, senha);

            return retorno;
        }

        [HttpPut("{token}:{senha}", Name = "Mudar Senha")]
        public ActionResult<User> Update(string token, string senha)
        {
            var user = _userService.GetUserByToken(token);

            if (user == null)
                return NotFound();

            string senhaCriptografada = Criptografar.CriptografarSenha(senha);
            user.Senha = senhaCriptografada;
            _userService.Update(token, user);
            return user;
        }

        [HttpPut("{token}", Name = "Mudar Config")]
        public ActionResult<User> Update(string token, ConfigAlterar config)
        {
            if (config == null)
                return NotFound();
            
            User result = _userService.UpdateConfig(token, config);

            if (result == null)
                return NotFound();

            return result;
        }
    }
}
using HRMoneyAPI.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using HRMoneyAPI.Criptografia;

namespace HRMoneyAPI.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IDatabaseSettingsUser settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UserCollectionName);
        }

        public User Login(string email, string senha) {
            User aux = new User();
            try
            {
                string senhaCriptografada = Criptografar.CriptografarSenha(senha);
                if (senhaCriptografada != null)
                {
                    aux = _users.Find<User>(user => user.Email == email && user.Senha == senhaCriptografada).FirstOrDefault();
                    if (aux != null)
                    {
                        return aux;
                    } else
                    {
                        return null;
                    }
                } else
                {
                    return null;
                }
            } catch
            {
                aux = null;
            }
            return null;
        }

        public User GetUserByToken(string token)
        {
            User aux = _users.Find<User>(user => user.Token == token).FirstOrDefault();

            return aux;
        }

        public string Create(string email, string senha)
        {
            User aux = new User();
            string retorno = null;
            try
            {
                if (_users.Find<User>(user => user.Email == email).FirstOrDefault() != null)
                {
                    retorno = "Email ja cadastrado";
                    return retorno;
                }
                string senhaCriptografada = Criptografar.CriptografarSenha(senha);
                string Token = Criptografar.GerarToken(email, senha);
                if (senhaCriptografada != null && Token != null)
                {
                    aux.Email = email;
                    aux.Senha = senhaCriptografada;
                    aux.Adquirido = false;
                    aux.Broad = true;
                    aux.Challenge = false;
                    aux.Delay_acao1 = 15000;
                    aux.Delay_acao2 = 20000;
                    aux.Delay_assistir = 50000;
                    aux.Delay_block = 3600000;
                    aux.Delay_ciclo = 600000;
                    aux.Delay_conta = 120000;
                    aux.Delay_meta = 3600000;
                    aux.Delay_perfil = 15000;
                    aux.Delay_rodar = 60000;
                    aux.Dizu = true;
                    aux.Everve = true;
                    aux.Farma = true;
                    aux.Ganhar = true;
                    aux.Kzom = true;
                    aux.Meta = 1000;
                    aux.Movimentar = false;
                    aux.Qtd = 30;
                    aux.Qtd_curtidas = 5;
                    aux.Siga = true;
                    aux.Token = Token;

                    _users.InsertOne(aux);
                    retorno = "Criado com sucesso.";
                    return retorno;
                } else
                {
                    retorno = "Erro ao gerar a senha e o Token";
                    return retorno;
                }
            } catch
            {
                retorno = "Erro ao gerar a senha/Token";
                return retorno;
            }
        }

        public User UpdateConfig(string token, ConfigAlterar NewConfig)
        {
            User user = GetUserByToken(token);
            if (user != null)
            {
                user.Qtd = NewConfig.Qtd;
                user.Delay_acao1 = NewConfig.Delay_acao1;
                user.Delay_acao2 = NewConfig.Delay_acao2;
                user.Delay_assistir = NewConfig.Delay_assistir;
                user.Delay_block = NewConfig.Delay_block;
                user.Delay_ciclo = NewConfig.Delay_ciclo;
                user.Delay_conta = NewConfig.Delay_conta;
                user.Delay_meta = NewConfig.Delay_meta;
                user.Delay_perfil = NewConfig.Delay_perfil;
                user.Delay_rodar = NewConfig.Delay_rodar;
                user.Meta = NewConfig.Meta;
                user.Movimentar = NewConfig.Movimentar;
                user.Challenge = NewConfig.Challenge;
                user.Qtd_curtidas = NewConfig.Qtd_curtidas;
                _users.ReplaceOne(us => us.Token == token, user);
                return user;
            } else
            {
                return null;
            }
        }

        public void Update(string token, User UserNew) => _users.ReplaceOne(User => User.Token == token, UserNew);

    }
}
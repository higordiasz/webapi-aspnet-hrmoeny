using HRMoneyAPI.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace HRMoneyAPI.Services
{
    public class InstagramService
    {
        private readonly IMongoCollection<Instagram> _instagram;

        public InstagramService()
        {
            var client = new MongoClient("");
            var database = client.GetDatabase("");

            _instagram = database.GetCollection<Instagram>("instagram_accounts");
        }

        public Instagram Get(string conta, string token) {
            Instagram aux = new Instagram();
            aux = _instagram.Find<Instagram>(instagram => instagram.Conta == conta && instagram.Token == token).FirstOrDefault();
            return aux;
        }

        public List<Instagram> GetAll(string token)
        {
            List<Instagram> aux = _instagram.Find<Instagram>(insta => insta.Token == token).ToList();

            return aux;
        }

        public Instagram Create(Instagram instagram)
        {
            if (_instagram.Find<Instagram>(insta => insta.Conta == instagram.Conta).FirstOrDefault() != null)
            {
                return null;
            }
            
            _instagram.InsertOne(instagram);
            
            return instagram;
        }

        public void Update(string Conta, Instagram instagramIn) => _instagram.ReplaceOne(instagram => instagram.Conta == Conta, instagramIn);

        public void Remove(string Conta) => _instagram.DeleteOne(instagram => instagram.Conta == Conta);
    }
}
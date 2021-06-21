using HRMoneyAPI.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace HRMoneyAPI.Services
{
    public class VersaoService
    {
        private readonly IMongoCollection<Versao> _versao;

        public VersaoService()
        {
            var client = new MongoClient("");
            var database = client.GetDatabase("");

            _versao = database.GetCollection<Versao>("versao");
        }

        public Versao Get() => _versao.Find(aluno => true).ToList().First();


        public void Put(Versao nova) {
            _versao.ReplaceOne<Versao>(a => true, nova);
        }
    }
}
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace HRMoneyAPI.Models
{
	public class Instagram
	{
        [BsonId()]
        public ObjectId Id { get; set; }

        [BsonElement("Token")]
        [BsonRequired()]
        public string Token { get; set; }

        [BsonElement("Conta")]
        [BsonRequired()]
        public string Conta { get; set; }

        [BsonElement("Senha")]
        [BsonRequired()]
        public string Senha { get; set; }

        [BsonElement("Ganhar")]
        [BsonRequired()]
        public Boolean Ganhar { get; set; }

        [BsonElement("Siga")]
        [BsonRequired()]
        public Boolean Siga { get; set; }

        [BsonElement("Kzom")]
        [BsonRequired()]
        public Boolean Kzom { get; set; }

        [BsonElement("Dizu")]
        [BsonRequired()]
        public Boolean Dizu { get; set; }

        [BsonElement("Farma")]
        [BsonRequired()]
        public Boolean Farma { get; set; }

        [BsonElement("Broad")]
        [BsonRequired()]
        public Boolean Broad { get; set; }

        [BsonElement("Everve")]
        [BsonRequired()]
        public Boolean Everze { get; set; }
    }
}
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HRMoneyAPI.Models
{
	public class User
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		[BsonElement("Email")]
        [BsonRequired()]
        public string Email { get; set; }

        [BsonElement("Senha")]
        [BsonRequired()]
        public string Senha { get; set; }

        [BsonElement("Token")]
        [BsonRequired()]
        public string Token { get; set; }

        [BsonElement("Adquirido")]
        [BsonRequired()]
        public bool Adquirido { get; set; }

        [BsonElement("Ganhar")]
        [BsonRequired()]
        public bool Ganhar { get; set; }

        [BsonElement("Siga")]
        [BsonRequired()]
        public bool Siga { get; set; }

        [BsonElement("Kzom")]
        [BsonRequired()]
        public bool Kzom { get; set; }

        [BsonElement("Dizu")]
        [BsonRequired()]
        public bool Dizu { get; set; }

        [BsonElement("Farma")]
        [BsonRequired()]
        public bool Farma { get; set; }

        [BsonElement("Broad")]
        [BsonRequired()]
        public bool Broad { get; set; }

        [BsonElement("Everve")]
        [BsonRequired()]
        public bool Everve { get; set; }

        [BsonElement("Challenge")]
        [BsonRequired()]
        public bool Challenge { get; set; }

        [BsonElement("Movimentador")]
        [BsonRequired()]
        public bool Movimentar { get; set; }

        [BsonElement("Qtd_curtidas")]
        [BsonRequired()]
        public int Qtd_curtidas { get; set; }

        [BsonElement("Delay_rodar")]
        [BsonRequired()]
        public int Delay_rodar { get; set; }

        [BsonElement("Delay_assistir")]
        [BsonRequired()]
        public int Delay_assistir { get; set; }

        [BsonElement("Delay_acao1")]
        [BsonRequired()]
        public int Delay_acao1 { get; set; }

        [BsonElement("Delay_acao2")]
        [BsonRequired()]
        public int Delay_acao2 { get; set; }

        [BsonElement("Delay_conta")]
        [BsonRequired()]
        public int Delay_conta { get; set; }

        [BsonElement("Delay_ciclo")]
        [BsonRequired()]
        public int Delay_ciclo { get; set; }

        [BsonElement("Delay_perfil")]
        [BsonRequired()]
        public int Delay_perfil { get; set; }

        [BsonElement("Delay_block")]
        [BsonRequired()]
        public int Delay_block { get; set; }

        [BsonElement("Delay_meta")]
        [BsonRequired()]
        public int Delay_meta { get; set; }

        [BsonElement("Meta")]
        [BsonRequired()]
        public int Meta { get; set; }

        [BsonElement("Qtd")]
        [BsonRequired()]
        public int Qtd { get; set; }
	}

    public class ConfigAlterar
    {
        [BsonElement("Challenge")]
        [BsonRequired()]
        public bool Challenge { get; set; }

        [BsonElement("Movimentador")]
        [BsonRequired()]
        public bool Movimentar { get; set; }

        [BsonElement("Qtd_curtidas")]
        [BsonRequired()]
        public int Qtd_curtidas { get; set; }

        [BsonElement("Delay_rodar")]
        [BsonRequired()]
        public int Delay_rodar { get; set; }

        [BsonElement("Delay_assistir")]
        [BsonRequired()]
        public int Delay_assistir { get; set; }

        [BsonElement("Delay_acao1")]
        [BsonRequired()]
        public int Delay_acao1 { get; set; }

        [BsonElement("Delay_acao2")]
        [BsonRequired()]
        public int Delay_acao2 { get; set; }

        [BsonElement("Delay_conta")]
        [BsonRequired()]
        public int Delay_conta { get; set; }

        [BsonElement("Delay_ciclo")]
        [BsonRequired()]
        public int Delay_ciclo { get; set; }

        [BsonElement("Delay_perfil")]
        [BsonRequired()]
        public int Delay_perfil { get; set; }

        [BsonElement("Delay_block")]
        [BsonRequired()]
        public int Delay_block { get; set; }

        [BsonElement("Delay_meta")]
        [BsonRequired()]
        public int Delay_meta { get; set; }

        [BsonElement("Meta")]
        [BsonRequired()]
        public int Meta { get; set; }

        [BsonElement("Qtd")]
        [BsonRequired()]
        public int Qtd { get; set; }
    }
}
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HRMoneyAPI.Models
{
    public class Versao
    {
        [BsonId()]
        public ObjectId Id { get; set; }

        [BsonElement("HRConfig")]
        [BsonRequired()]
        public string HRConfig { get; set; }

        [BsonElement("HRGanhar")]
        [BsonRequired()]
        public string HRGanhar { get; set; }

        [BsonElement("HRSiga")]
        [BsonRequired()]
        public string HRSiga { get; set; }

        [BsonElement("HRKzom")]
        [BsonRequired()]
        public string HRKzom { get; set; }

        [BsonElement("HRDizu")]
        [BsonRequired()]
        public string HRDizu { get; set; }

        [BsonElement("HRFarma")]
        [BsonRequired()]
        public string HRFarma { get; set; }

        [BsonElement("HRBroad")]
        [BsonRequired()]
        public string HRBroad { get; set; }

        [BsonElement("HREverze")]
        [BsonRequired()]
        public string HREverze { get; set; }
    }
}

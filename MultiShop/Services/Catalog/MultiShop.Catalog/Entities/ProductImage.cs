using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class ProductImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductImageId { get; set; }

        public string ProductImages1 { get; set; }
        public string ProductImages2 { get; set; }
        public string ProductImages3 { get; set; }

        public string ProductId { get; set; }
        [BsonIgnore]
        public Product Product { get; set; }
    }
}

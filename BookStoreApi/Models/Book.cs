using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace BookStoreApi.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Nombre")]
        [JsonPropertyName("Nombre")]
        public string NameBook { get; set; } = null!;

        public decimal Price { get; set; }

        public string Categoria { get; set; } = null!;

        public string Autor { get; set; } = null!;


    }
}

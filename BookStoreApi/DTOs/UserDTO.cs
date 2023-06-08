using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace BookStoreApi.DTOs
{
    public class UserDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? UserId { get; set; }

        [BsonElement("Name")]
        [JsonPropertyName("Name")]
        public string UserName { get; set; } = null!;

        public string Email { get; set; } = null!;


    }
}

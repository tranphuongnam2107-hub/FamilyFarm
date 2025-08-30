using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FamilyFarm.Models.Models
{
    public class PostCategory
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryPostId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string PostId { get; set; }
        public string? CategoryName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

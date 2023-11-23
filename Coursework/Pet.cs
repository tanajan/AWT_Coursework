using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Coursework
{
    internal class Pet
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("SpeciesName")]
        public string SpeciesName { get; set; }
        [BsonElement("Weight")]
        public double Weight { get; set; }
        [BsonElement("OwnerName")]
        public string OwnerName { get; set; }
        [BsonElement("Status")]
        public string Status { get; set; }

        public Pet(string name, string speciesName, double weight, string ownerName, string status)
        {
            Name = name;
            SpeciesName = speciesName;
            Weight = weight;
            OwnerName = ownerName;
            Status = status;
        }
    }
}

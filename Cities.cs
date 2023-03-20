using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GeoSpatialData
{
    class Cities
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }


        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("lat")]
        public string Lat { get; set; }

        [BsonElement("lng")]
        public string Lng { get; set; }

        [BsonElement("country")]
        public string Country { get; set; }

        [BsonElement("iso2")]
        public string Iso2 { get; set; }

        [BsonElement("admin_name")]
        public string AdminName { get; set; }

        [BsonElement("capital")]
        public string Capital { get; set; }

        [BsonElement("population")]
        public string Population { get; set; }

        [BsonElement("population_proper")]
        public string PopulationProper { get; set; }
    }
}

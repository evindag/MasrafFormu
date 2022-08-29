using Core.Entites.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Check:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Date { get; set; }
        public double CheckCost { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Company { get; set; }

        public string Person { get; set; }
        public string Address { get; set; }

    }
}

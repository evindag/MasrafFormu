using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Fis:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int FisId { get; set; } 
        public string BelgeTarihi { get; set; }
        public string FisNo { get; set; }
        public string Firma { get; set; }
        public string Aciklama { get; set; }
        public string FisTuru { get; set; }
        public double ToplamFis { get; set; }
        public double Kdv { get; set; }
        public string Gorsel { get; set; }
        public string Kisi { get; set; }
      
    }
}

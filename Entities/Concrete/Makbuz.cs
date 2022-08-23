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
    public class Makbuz:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int MakbuzId { get; set; }
        public int Tarih { get; set; }
        public double MakbuzTutari { get; set; }
        public string MakbuzAciklamasi { get; set; }
        public string MakbuzGorseli { get; set; }
        public string FirmaAdi { get; set; }

        public string YetkiliAd { get; set; }
        public string Adres { get; set; }

    }
}

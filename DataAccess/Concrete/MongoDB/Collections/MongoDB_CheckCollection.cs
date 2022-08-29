using System;
using DataAccess.Concrete.Databases.MongoDB.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_CheckCollection : ICollection
    {
        public string CollectionName { get; set ; }
        public MongoDB_CheckCollection()
        {
            CollectionName = "Checks";
        }
    }
}

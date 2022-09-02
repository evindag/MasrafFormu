using DataAccess.Concrete.Databases.MongoDB.Collections;
using System;

using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB.Collections
{
    public class MongoDB_UserCollection :ICollection
    {
        public string CollectionName { get; set; }

        

        public MongoDB_UserCollection()
        {
            CollectionName = "Users";
        }

        
    }
}

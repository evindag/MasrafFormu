using Core.DataAccess.Databases.MongoDB;
using Core.Entites.Abstract;
using Core.Entites.Concrete;
using DataAccess.Concrete.Databases.MongoDB.Collections;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Threading;

namespace DataAccess.Concrete.Databases.MongoDB
{
    public class MongoDB_Context<TEntity, PredefinedCollection> : IDisposable, IMongoDB_Context<TEntity> 
        where PredefinedCollection : class, ICollection, new()
        where TEntity : class, IEntity, new()
    {
        public MongoClient client { get; set; }
        public IMongoDatabase database { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public IMongoCollection<TEntity> collection { get; set; }
        private PredefinedCollection predefinedCollection = new PredefinedCollection();

        public MongoDB_Context()
        {
            GetMongoDBCollection();
        }
        public IMongoCollection<TEntity> GetMongoDBCollection()
        {
        tryAgain:
            try
            {



                client = new MongoClient("mongodb://localhost:27017");
                database = client.GetDatabase("MasrafDB");
                collection = database.GetCollection<TEntity>(predefinedCollection.CollectionName);
                return collection;

            }
            catch (System.Exception)
            {

                Thread.Sleep(15000);
                goto tryAgain;

            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

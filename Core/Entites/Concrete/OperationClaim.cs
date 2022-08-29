using Core.Entites.Abstract;

namespace Core.Entites.Concrete
{
    public class OperationClaim : IEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}

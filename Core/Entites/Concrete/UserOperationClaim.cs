using Core.Entites.Abstract;

namespace Core.Entites.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public string Id { get; set; }
        public int UserId { get; set; }
        public string OperationClaimId { get; set; }
    }
}

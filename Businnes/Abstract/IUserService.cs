﻿using Core.Entites.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(string userId);
        void Add(User user);
        User GetByMail(string email);
    }
}

﻿using Backend.Core.Repository;
using Backend.Business.Entities;

namespace Backend.Business.Repository
{
    public interface IClientRepository : IReadonlyRepository<ClientEntity>
    {
    }
}

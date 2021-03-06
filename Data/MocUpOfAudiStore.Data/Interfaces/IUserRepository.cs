﻿namespace MocUpOfAudiStore.Data.Interfaces
{
    using System.Threading.Tasks;
    using MocUpOfAudiStore.Data.Common.Repositories;
    using Models;

    public interface IUserRepository : IRepository<ApplicationUser>
    {
        Task<ApplicationUser> GetByEmailOrDefault(string email);

        Task<ApplicationUser> GetByIdWithRolesAsync(string userId);
    }
}
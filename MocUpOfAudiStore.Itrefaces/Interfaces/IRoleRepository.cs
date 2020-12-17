namespace MocUpOfAudiStore.Data.Interfaces
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using MocUpOfAudiStore.Data.Common.Repositories;

   public interface IRoleRepository : IRepository<IdentityRole>
   {
       Task<string> GetIdByNameAsync(string name);
   }
}

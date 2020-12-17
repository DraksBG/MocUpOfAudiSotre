namespace MocUpOfAudiStore.Services.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICacheService
    {
        Task AddTimedCacheAsync(object obj, string cacheKey, string cacheType, DateTime dateTime);
        Task AddInfinityCacheAsync(object obj, string cacheKey, string cacheType);
        Task RemoveAsync(string cacheType);
        Task<TResult> GetOrDefaultAsync<TResult>(string cacheKey) where TResult : class;

    }
}

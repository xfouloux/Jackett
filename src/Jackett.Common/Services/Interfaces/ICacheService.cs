using System.Collections.Generic;
using Jackett.Common.Indexers;
using Jackett.Common.Models;

namespace Jackett.Common.Services.Interfaces
{
    public interface ICacheService
    {
        List<ReleaseInfo> Search(IIndexer indexer, TorznabQuery query);
        void CacheResults(IIndexer indexer, TorznabQuery query, List<ReleaseInfo> releases);
        List<TrackerCacheResult> GetCachedResults();
        void CleanIndexerCache(IIndexer indexer);
<<<<<<< HEAD
=======
        void CleanCache();
>>>>>>> a983537cc90fd4e95b6c94969ff72e816ae37821
    }
}

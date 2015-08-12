using System.Collections.Generic;

namespace FalconSharp
{
    public class FalconEntityCollectionResponse<TEntity> : FalconResponse
    {
        public IEnumerable<TEntity> Items { get; set; }
    }
}
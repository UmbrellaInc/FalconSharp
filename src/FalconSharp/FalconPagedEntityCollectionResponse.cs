namespace FalconSharp
{
    public class FalconPagedEntityCollectionResponse<TEntity> : FalconEntityCollectionResponse<TEntity>
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public int PageSize { get; set; }
    }
}
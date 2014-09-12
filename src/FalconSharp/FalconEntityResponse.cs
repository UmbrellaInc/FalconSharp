namespace FalconSharp
{
	public class FalconEntityResponse<TEntity> : FalconResponse
	{
		public TEntity Item { get; set; }
	}
}
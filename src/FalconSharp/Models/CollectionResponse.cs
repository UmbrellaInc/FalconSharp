using System.Collections.Generic;

namespace FalconSharp.Models
{
	public class CollectionResponse<TEntity>
	{
		public IEnumerable<TEntity> Items { get; set; }
	}
}
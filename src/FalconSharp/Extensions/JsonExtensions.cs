using Newtonsoft.Json;

namespace FalconSharp.Extensions
{
	internal static class JsonExtensions
	{
		public static TEntity DeserializeJsonTo<TEntity>(this string json)
		{
			return JsonConvert.DeserializeObject<TEntity>(json);
		}
	}
}
using Tesera.Types.Enums;

namespace Tesera.Models
{
	public class CountryInfo
	{
		public string? Type;
		public string? Value;
		public string? Alias;
		public long TeseraId;
		public string? Name;
		public string? Name2;

		public TeseraType GetTeseraType() => Enum.TryParse(typeof(TeseraType), this.Type, out object? result) ? (TeseraType)result : Types.Enums.TeseraType.Unknown;
	}
}
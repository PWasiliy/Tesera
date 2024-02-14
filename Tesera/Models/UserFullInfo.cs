using Tesera.Types.Enums;

namespace Tesera.Models
{
	public class UserFullInfo
	{
		public long TeseraId;
		public string? Login;
		public string? Name;
		public string? Comment;
		public string? AvatarUrl;
		public string? Gender;
		public long Rating;
		public long Experience;
		public DateTime CreationDateUtc;
		public DateTime ModificationDateUtc;
		public long CollectionCount;
		public long GamesAdded;
		public long NewsAdded;
		public long ArticlesAdded;
		public long JournalsAdded;
		public long ThoughtsAdded;
		public readonly CountryInfo Country;
		public readonly CityInfo City;

		public UserFullInfo(CountryInfo country, CityInfo city)
		{
			this.Country = country;
			this.City = city;
		}

		public Gender GetGender() => Enum.TryParse(typeof(Gender), this.Gender, out object? result) ? (Gender)result : Types.Enums.Gender.Unknown;
	}
}
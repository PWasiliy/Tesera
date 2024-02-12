using Tesera.Types;
using Tesera.Types.Enums;
using Tesera.Models;

namespace Tesera.Collections
{
	public class Base : UriGetRequest<IEnumerable<CustomCollectionGameInfo>>
	{
		readonly CollectionType _collectionType;
		readonly string _userAlias;
		readonly GamesType _gamesType;
		readonly int _limit = 100;

		public Base(CollectionType collectionType, string userAlias, GamesType gamesType, int limit = 100)
		{
			_collectionType = collectionType;
			_userAlias = userAlias;
			_gamesType = gamesType;
			_limit = limit;
		}
		public override string GetUri()
		{
			return $"{base.GetUri()}/{_collectionType}/{_userAlias}?GamesType={_gamesType}&Limit={_limit}";
		}
	}
}
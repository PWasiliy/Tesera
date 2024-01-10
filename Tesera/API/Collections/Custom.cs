using Tesera.Models;
using Tesera.Types;
using Tesera.Types.Enums;

namespace Tesera.API.Collections
{
    public class Custom : UriGetRequest<CustomCollectionInfo>
    {
        readonly int _id;
        public Custom(int collectionId) => _id = collectionId;
        public override string GetUri() => $"{base.GetUri()}/{_id}";

        public class GamesClear : UriGetRequest<IEnumerable<CustomCollectionGameInfo>>
        {
            readonly int _id;
            readonly GamesType _gamesType;
            readonly int _limit = 100;

            public GamesClear(int collectionId, GamesType gamesType, int limit = 100)
            {
                _id = collectionId;
                _gamesType = gamesType;
                _limit = limit;
            }
            public override string GetUri()
            {
                string url = base.GetUri();
                return $"{url.Insert(url.LastIndexOf('/'), $"/{_id}")}?GamesType={_gamesType}&Limit={_limit}";
            }
        }
    }
}

using Tesera.Models;
using Tesera.Types;

namespace Tesera.API
{
    public class Games : UriGetRequest<GameInfoResponse>
    {
        readonly string _gameAlias;
        public Games(string gameAlias) => _gameAlias = gameAlias;
        public override string GetUri() => $"{base.GetUri()}/{_gameAlias}";
    }
}

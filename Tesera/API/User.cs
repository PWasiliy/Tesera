using Tesera.Models;
using Tesera.Types;

namespace Tesera.API
{
	public class User : UriGetRequest<UserFullInfoResponse>
	{
		readonly string _alias;
		public User(string userAlias) => _alias = userAlias;
		public override string GetUri() => base.GetUri() + '/' + _alias; 
	}
}
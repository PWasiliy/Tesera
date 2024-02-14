namespace Tesera.Models
{
	public class UserFullInfoResponse
	{
		public readonly UserFullInfo User;
		public int GamesInCollection;
		public readonly IEnumerable<CollectionGameInfo> Collection;

		public UserFullInfoResponse(UserFullInfo user, IEnumerable<CollectionGameInfo> collection)
		{
			this.User = user;
			this.Collection = collection;
		}
	}
}
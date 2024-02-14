namespace Tesera.Models
{
	public class CollectionGameInfo
	{
		public long RelationId;
		public DateTime CreationDateUtc;
		public DateTime EventDate;
		public string? Comment;
		public readonly GameInfoShort Game;

		public CollectionGameInfo(GameInfoShort game) => this.Game = game;
	}
}

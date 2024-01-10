namespace Tesera.Models
{
    public class CustomCollectionGameInfo
	{
		public DateTime? CreationDateUtc;
		public string? Comment;
        public readonly GameInfoShort Game;
        public CustomCollectionGameInfo(GameInfoShort game) => this.Game = game;
    }
}

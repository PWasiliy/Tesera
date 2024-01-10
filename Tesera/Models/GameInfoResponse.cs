namespace Tesera.Models
{
	public class GameInfoResponse
	{
		public readonly GameInfo Game;

		public int OwnersTotal;
		public int SellTotal;
		public int BuyTotal;
		public int SellTotalAll;
		public int BuyTotalAll;
		public int CommentsTotal;
		public int ReportsTotal;
		public int PhotosTotal;
		public int FilesTotal;
		public int LinksTotal;
		public int VideoExternalTotal;
		public int VideoInternalTotal;

		public readonly IEnumerable<GameInfoShort> Similars;
		public readonly IEnumerable<GameInfoShort> Relateds;

		public GameInfoResponse(GameInfo game, IEnumerable<GameInfoShort> similars, IEnumerable<GameInfoShort> relateds)
		{
			this.Game = game;
			this.Similars = similars;
			this.Relateds = relateds;
		}
	}
}

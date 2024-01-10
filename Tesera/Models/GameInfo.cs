namespace Tesera.Models
{
	public class GameInfo : GameInfoShort
	{
		public string? Description;
		public DateTime ModificationDateUtc;
		public string? PhotoUrl2;
		public int PlayersMin;
		public int PlayersMax;
		public int PlayersMinRecommend;
		public int PlayersMaxRecommend;
		public int PlayersAgeMin;
		public int TimeToLearn;
		public int PlaytimeMin;
		public int PlaytimeMax;
	}
}

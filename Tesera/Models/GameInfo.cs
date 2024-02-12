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

		public string? GetPlayersCount(string onePlayersCount = "{0}", string twoPlayersCount = "{0}-{1}", string threePlayersCount = "{0}-{1} ({2})", string fourPlayersCount = "{0}-{1} ({2}-{3})")
		{
			int[] players = [this.PlayersMin, this.PlayersMax, this.PlayersMinRecommend, this.PlayersMaxRecommend];
			if (players.All((int value) => value == 0))
				return null;

			if (!players.Contains(0) && this.PlayersMin != this.PlayersMax && this.PlayersMinRecommend != this.PlayersMaxRecommend && (this.PlayersMin != this.PlayersMinRecommend || this.PlayersMax != this.PlayersMaxRecommend))
				return string.Format(fourPlayersCount, [this.PlayersMin, this.PlayersMax, this.PlayersMinRecommend, this.PlayersMaxRecommend]);

			int playersCount = this.PlayersMin == 0 ? this.PlayersMinRecommend == this.PlayersMaxRecommend ? this.PlayersMinRecommend : 0 : this.PlayersMin == this.PlayersMax ? this.PlayersMin : 0; 
			if (playersCount != 0)
				return string.Format(onePlayersCount, [playersCount]);

			if (this.PlayersMin == this.PlayersMax)
			{
				if (this.PlayersMinRecommend != 0 && this.PlayersMaxRecommend != 0)
					return string.Format(twoPlayersCount, [this.PlayersMinRecommend, this.PlayersMaxRecommend]);
			}
			else if (this.PlayersMin != 0 && this.PlayersMax != 0) {
				if (this.PlayersMinRecommend == this.PlayersMaxRecommend && this.PlayersMinRecommend != 0)
					return string.Format(threePlayersCount, [this.PlayersMin, this.PlayersMax, this.PlayersMinRecommend]);
				else
					return string.Format(twoPlayersCount, [this.PlayersMin, this.PlayersMax]);
			}

			return null;
		}

	}
}

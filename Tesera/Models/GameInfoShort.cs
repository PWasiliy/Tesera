namespace Tesera.Models
{
    public class GameInfoShort
    {
        public int Id;
		public int TeseraId;
		public int BggId;
		public string? Title;
		public string? Title2;
		public string? Title3;
		public string? Alias;
		public string? DescriptionShort;
		public DateTime? CreationDateUtc;
		public string? PhotoUrl;
		public int Year;
		public int NumVotes;
		public float RatingUser;
		public float N10Rating;
		public float N20Rating;
		public float BggRating;
		public float BggGeekRating;
		public int BggNumVotes;
		public float RatingMy;
		public int CommentsTotal;
		public int CommentsTotalNew;
		public string? TeseraUrl;
		public bool IsAddition;
	}
}

namespace Tesera.Models
{
    public class CustomCollectionInfo
    {
        public int Id;
		public DateTime? CreationDateUtc;
		public DateTime ModificationDateUtc;
        public string? Title;
        public string? Description;
        public int GamesTotal;
        public bool IsPrivate;
    }
}

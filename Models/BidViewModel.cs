namespace AfribaseAuction.Models
{
    public class BidViewModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string ImagePath { get; set; }
        public List<decimal> HighestBids { get; set; }
        public int TotalBids { get; set; }
    }
}

using System.Collections.Generic;

namespace AfribaseAuction.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public string Buyer { get; set; } = string.Empty;
        public string Artwork { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public decimal Value { get; set; }

        public List<decimal> HighestBids { get; set; } = new List<decimal>();
    }
}

using Microsoft.AspNetCore.Mvc;
using AfribaseAuction.Models;


namespace AfribaseAuction.Controllers
{
    public class BidsController : Controller
    {
        public IActionResult Index()
        {
            var bids = new List<BidViewModel>
        {
            new BidViewModel
            {
                Title = "Timid beauty",
                Artist = "Caephus Semenya",
                ImagePath = "/images/timid-beauty.jpg",
                HighestBids = new List<decimal> {17500, 15800, 14300, 7600},
                TotalBids = 12
            },
            new BidViewModel
            {
                Title = "Joy in colour",
                Artist = "Sifiso Jwala",
                ImagePath = "/images/joy-in-colour.jpg",
                HighestBids = new List<decimal> {72800, 54900, 39400, 37700},
                TotalBids = 35
            },
            new BidViewModel
            {
                Title = "Mzansi",
                Artist = "Johnathan Maputla",
                ImagePath = "/images/mzansi.jpg",
                HighestBids = new List<decimal> {9800, 6800, 5400, 4700},
                TotalBids = 9
            }
        };

            return View(bids);
        }
    }
}

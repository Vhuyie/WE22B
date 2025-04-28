using Microsoft.AspNetCore.Mvc;
using AfribaseAuction.Models;
using System.Collections.Generic;


namespace AfribaseAuction.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            var sales = new List<Sale>
           {
                new Sale { Buyer = "Thabo Mokoena", Artwork = "Horizon Glow", Artist = "Pierneef", Value = 120000 },
                new Sale { Buyer = "Abigail Jacobs", Artwork = "Urban Rhythm", Artist = "Sam Nhlengethwa", Value = 150000 },
                new Sale { Buyer = "Priya Naidoo", Artwork = "Zulu Maiden", Artist = "Gerard Sekoto", Value = 85500 },
                new Sale { Buyer = "Michael Smith", Artwork = "Golden Harvest", Artist = "Irma Stern", Value = 1500000 },
                new Sale { Buyer = "Chad Petersen", Artwork = "Mother & Child", Artist = "Dumile Feni", Value = 325000 },
                new Sale { Buyer = "Zinhle Mthembu", Artwork = "Xhosa Dance", Artist = "George Pemba", Value = 190000 },
                new Sale { Buyer = "Farhaan Essop", Artwork = "The Journey", Artist = "William Kentridge", Value = 2800000 },
                new Sale { Buyer = "Michael Smith", Artwork = "Golden Harvest", Artist = "Irma Stern", Value = 1500000 }
            };
            return View(sales);
        }
    }
}

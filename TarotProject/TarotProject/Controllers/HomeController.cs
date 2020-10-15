using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TarotProject.Models;

namespace TarotProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<Card> Draw(List<Card> deck,Spread s)
        {
            Random rnd = new Random();
            List<int> picked = new List<int>();
            List<Card> drawnCard = new List<Card>();
            for(int i = 0; i < s.CardNumber; i++)
            {
                int r = rnd.Next(deck.Count);

                if (picked.Count > 0)
                {
                    while (picked.Any(item =>item == r) ) 
                    {
                        r = rnd.Next(deck.Count);
                    }

                }
                drawnCard.Add(deck[r]);
            }
            return drawnCard;
        }
    }
}

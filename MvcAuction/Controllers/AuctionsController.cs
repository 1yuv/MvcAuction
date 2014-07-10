using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAuction.Controllers
{
    public class AuctionsController : Controller
    {
        //
        // GET: /Auctions/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Auction()
        {
            var auction = new MvcAuction.Models.Auction()
            {
                Title = "ExampleAuction",
                Description = "This is an exmaple Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = null
            };                       

            // Pass data
            //ViewData["Auction"] = auction;
            //ViewBag.Auction = auction;
            return View(auction);
        }


        public ActionResult TempDataDemo()
        {
            TempData["SuccessMessage"] = "The action succeeded!";
            return RedirectToAction("Index");
        }

	}
}
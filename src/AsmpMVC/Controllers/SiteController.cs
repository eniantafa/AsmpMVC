using AsmpMVC.Data;
using AsmpMVC.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsmpMVC.Controllers
{
    public class SiteController:Controller
    {


        private AppDbContext _context;

        public SiteController(AppDbContext context)
        {
            _context = context;
        }
        public SiteController()
        {
        }

        // GET: Site

        public ActionResult CreateSite()
        {
            return View("~/Views/Site/Create.cshtml", new SiteViewModel());
        }


        //[HttpPost]
        public ActionResult Create(SiteViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Site Problem");

                return View();
                //Redirect tek nje error page
            }

            Site site = new Site()
            {
                SiteNumber = viewModel.SiteNumber,
                ContractDate = DateTime.Now,
                HomeOwner = viewModel.HomeOwner,
                ContactNumber = viewModel.ContactNumber,
                ContactEmail = viewModel.ContactEmail,
                HouseType = viewModel.HouseType,
                ContractValueExGST = viewModel.ContractValueExGST,
                ContractValueIncGST = viewModel.ContractValueIncGST,
                PreContactEOT = viewModel.PreContactEOT,
                DOPCDate = DateTime.Now,
                TwelveMonthMaintenance = DateTime.Now.AddYears(1),
                Note = viewModel.Note
            };

            _context.Sites.Add(site);
            _context.SaveChanges();

            return View();
        }

        public ActionResult Edit(int id)
        {
            using (AppDbContext ctx = new AppDbContext())
            {
                Site mySite = ctx.Sites.Where(n => n.Id == id).FirstOrDefault();
                return View(mySite);
            }
        }

        public ActionResult EditConfirm(Site site)
        {
            Site oldSite = _context.Sites.Where(n => n.Id == site.Id).FirstOrDefault();
            oldSite.HomeOwner = site.HomeOwner;
            //futen vlerat e tjera

            _context.Sites.AddOrUpdate(oldSite);
            _context.SaveChanges();

            return View();
        }

    }
}

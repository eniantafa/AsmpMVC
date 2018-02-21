using AsmpMVC.Data;
using AsmpMVC.Data.Models;
using AsmpMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsmpMVC.Controllers
{
    public class IssueController:Controller
    {

        private AppDbContext _context;

        public IssueController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Issue
        public ActionResult CreateIssue()
        {
            return View(new IssueViewModel());
        }

        [HttpPost]
        public ActionResult CreateIssue(IssueViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "IssueProblem");

                return View();
                //Redirect tek nje error page
            }


            Issue issue = new Issue()
            {
                Code = viewModel.Code,
                Date = DateTime.Now,
                Category = viewModel.Category,
                Item = viewModel.Item,
                Priority = viewModel.Priority,
                Status = viewModel.Status,
                Note = viewModel.Note

            };

            _context.Issues.Add(issue);
            _context.SaveChanges();

            return View();
        }

    }
}

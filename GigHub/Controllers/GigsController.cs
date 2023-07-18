using GigHub.Models;
using GigHub.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
       private readonly ApplicationDbContext _dbContext;
        public GigsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var ViewModel = new GigFormViewModel
            {
                Genres = _dbContext.Genres.ToList()
            };
            return View(ViewModel);
        }
    }
}
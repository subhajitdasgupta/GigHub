﻿using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNet.Identity;
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

        [Authorize]
        public ActionResult Create()
        {
            var ViewModel = new GigFormViewModel
            {
                Genres = _dbContext.Genres.ToList()
            };
            return View(ViewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                viewModel.Genres = _dbContext.Genres.ToList();
                return View("Create", viewModel);
            }

            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue

            };
            _dbContext.Gigs.Add(gig);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
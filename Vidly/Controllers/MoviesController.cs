using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class MoviesController : Controller
    {

        private VidlyContext _context;

        /// <summary>
        /// 
        /// </summary>
        public MoviesController()
        {
            _context = new VidlyContext();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

    }
}
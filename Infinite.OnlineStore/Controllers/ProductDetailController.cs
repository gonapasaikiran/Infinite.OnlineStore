using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infinite.OnlineStore.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Infinite.OnlineStore.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly ApplicationDbContext _context = null;
        public ProductDetailController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: ProductDetail
        
        public ActionResult Index()
        {
            return View();
        }
    }
}
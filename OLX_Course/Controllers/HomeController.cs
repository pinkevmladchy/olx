using OLX_Course.Entities;
using OLX_Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OLX_Course.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ActionResult Index()
        {
            List<CategoryViewModel> model = context.Categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Image = "/photo/" + x.Image,
                Name = x.Name
            }).ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TovarsForCategories(int id)
        {
            var categoria = context.Categories.FirstOrDefault(x => x.Id.Equals(id)).Name;
            List<TovarViewModel> model = context.Tovars.Select(x => new TovarViewModel
            {
                Id = x.Id,
                Image = x.Images.FirstOrDefault().Image,
               Name=x.Name,
               Cost=x.Cost,
               Description=x.Description,
               City_Name=x.City.Name,
               Category_name=x.Category.Name,
               User_name=x.ApplicationUser.UserName
            }).Where(x=>x.Category_name==categoria).ToList();
            return View(model);
        }
    }
}
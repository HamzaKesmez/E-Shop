using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Shop.Controllers
{
    public class ProductController : Controller
    {
        DataContext db = new DataContext();
        // GET: Product
        ProductRepository productRepository = new ProductRepository();
        public PartialViewResult PopularProduct()
        {
            var product = productRepository.GetPopularProduct();
            ViewBag.Popular = product;
            return PartialView();
        }
        [Route("product/productdetails/{id}/{name}")]
        public ActionResult ProductDetails(int id)
        {
            var details = productRepository.GetById(id);
            var yorum=db.Comments.Where(x => x.ProductId == id).ToList();
            ViewBag.yorum = yorum;
            return View(details);
        }
        [HttpPost]
        public ActionResult Comment(Comment data)
        { 
            if(User.Identity.IsAuthenticated)
            {
                db.Comments.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}
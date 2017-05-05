using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using Studio27SalonOfBeauty.Models.EntityModels;

using Studio27SalonOfBeauty.Services;
using System.IO;
using Studio27SalonOfBeauty.Models.BindingModels;
using Studio27SalonOfBeauty.Models.ViewModels.Products;

namespace Studio27SalonOfBeauty.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : Controller
    {
        private ProductsService service;

        public ProductsController()
        {
            this.service = new ProductsService();
        }
       
        [Route("Index")]
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        [Route("Details")]
        [Route("~/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IEnumerable<SubProduct> products = this.service.GetAllSubProducts(id);
            
            return View(products);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(AddProductBinding productBM)
        {
            if (ModelState.IsValid)
            {
              this.service.AddProductBindings(productBM);
                return RedirectToAction("Products");
            }

            return View();
        }

        [HttpGet]
        [Authorize(Roles ="Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = this.service.Context.Products.Find(id);
            var productVm= AutoMapper.Mapper.Map<Product, EditProductViewModel>(product);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(productVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(EditProductViewModel editProductVm)
        {
            if (ModelState.IsValid)
            {
                
                this.service.EditProduct(editProductVm);
                this.service.Context.SaveChanges();
                return this.RedirectToAction("Index","Products");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = this.service.Context.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = this.service.Context.Products.Find(id);
            this.service.Context.Products.Remove(product);
            this.service.Context.SaveChanges();
            return RedirectToAction("Products");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.service.Context.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Products(int? id)
        {
            IEnumerable<SubProduct> products = this.service.GetAllSubProducts(id);
            return View();
        }

        [HttpGet]
        [Route("CareLine")]
        //[Route("~/")]
        public ActionResult CareLine()
        {

            IEnumerable<Product> products = this.service.GetAllCareLineProducts("careLine");
            return View(products);
        }


        [HttpGet]
        [Route("Man")]
        //[Route("~/")]
        public ActionResult Man()
        {

            IEnumerable<Product> products = this.service.GetAllManProducts("Man");
            return View(products);
        }

        [HttpGet]
        [Route("So Pure")]
        //[Route("~/")]
        public ActionResult SoPure()
        {
            IEnumerable<Product> products = this.service.GetAllSoPureProducts("SoPure");
            return View(products);
        }
    }
}
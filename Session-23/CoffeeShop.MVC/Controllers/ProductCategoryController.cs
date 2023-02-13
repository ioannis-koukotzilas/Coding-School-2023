using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Models;
using CoffeeShop.MVC.Models.ProductCategory;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.MVC.Controllers {

    public class ProductCategoryController : Controller {

        private readonly IEntityRepo<ProductCategory> _productCategoryRepo;

        public ProductCategoryController(IEntityRepo<ProductCategory> productCategoryRepo) {
            _productCategoryRepo = productCategoryRepo;
        }

        // GET: /ProductCategory
        public ActionResult Index() {
            var productCategories = _productCategoryRepo.GetAll();
            return View(model: productCategories);
        }

        // GET: /ProductCategory/Create
        public ActionResult Create() {
            return View();
        }

        // POST: /ProductCategory/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCategoryCreateDto productCategory) {
            if (!ModelState.IsValid) {
                return View();
            }

            var newProductCat = new ProductCategory(productCategory.Code, productCategory.Description, productCategory.ProductType);
            _productCategoryRepo.Add(newProductCat);
            return RedirectToAction("Index");
        }

        // GET: /ProductCategory/Edit
        public ActionResult Edit(int id) {
            var dbProductCat = _productCategoryRepo.GetById(id);
            if (dbProductCat == null) {
                return NotFound();
            }

            var editProductCategory = new ProductCategoryEditDto {
                Id = dbProductCat.Id,
                Code = dbProductCat.Code,
                Description = dbProductCat.Description,
                ProductType = dbProductCat.ProductType
            };
            return View(model: editProductCategory);
        }

        // POST: /ProductCategory/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductCategoryEditDto productCategory) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbProductCat = _productCategoryRepo.GetById(id);
            if (dbProductCat == null) {
                return NotFound();
            }

            dbProductCat.Code = productCategory.Code;
            dbProductCat.Description = productCategory.Description;
            dbProductCat.ProductType = productCategory.ProductType;

            _productCategoryRepo.Update(id, dbProductCat);
            return RedirectToAction(nameof(Index));
        }

        // GET: /ProductCategory/Delete
        public ActionResult Delete(int id) {
            var dbProductCat = _productCategoryRepo.GetById(id);
            if (dbProductCat == null) {
                return NotFound();
            }

            var deleteProductCategory = new ProductCategoryDeleteDto {
                Id = dbProductCat.Id,
                Code = dbProductCat.Code,
                Description = dbProductCat.Description,
                ProductType = dbProductCat.ProductType

            };
            return View(model: deleteProductCategory);
        }

        // POST: /ProductCategory/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            _productCategoryRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }

}
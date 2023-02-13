using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Models;
using CoffeeShop.MVC.Models.Product;
using CoffeeShop.MVC.Models.ProductCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoffeeShop.MVC.Controllers {

    public class ProductController : Controller {

        private readonly IEntityRepo<Product> _productRepo;
        private readonly IEntityRepo<ProductCategory> _productCategoryRepo;

        public ProductController(IEntityRepo<Product> productRepo, IEntityRepo<ProductCategory> productCategoryRepo) {
            _productRepo = productRepo;
            _productCategoryRepo = productCategoryRepo;
        }

        // GET: /Product
        public ActionResult Index() {
            var products = _productRepo.GetAll();
            return View(model: products);
        }

        // GET: /Product/Create
        public ActionResult Create() {
            var newProduct = new ProductCreateDto();
            var productCategories = _productCategoryRepo.GetAll();
            foreach (var prodCategory in productCategories) {
                newProduct.ProductCategoryList.Add(new SelectListItem(prodCategory.Description, prodCategory.Id.ToString()));
            }
            return View(model: newProduct);
        }

        // POST: /Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCreateDto product) {
            if (!ModelState.IsValid) {
                return View();
            }

            var dbProduct = new Product(product.Code, product.Description, product.Price, product.Cost);

            // TODO: Check this
            dbProduct.ProductCategoryId = product.ProductCategoryId;

            _productRepo.Add(dbProduct);
            return RedirectToAction("Index");
        }

        // GET: /Product/Edit
        public ActionResult Edit(int id) {
            var dbProduct = _productRepo.GetById(id);
            if (dbProduct == null) {
                return NotFound();
            }

            var editProduct = new ProductEditDto {
                Id = dbProduct.Id,
                Code = dbProduct.Code,
                Description = dbProduct.Description,
                Price = dbProduct.Price,
                Cost = dbProduct.Cost,
                ProductCategoryId = dbProduct.ProductCategoryId
            };

            var productCategories = _productCategoryRepo.GetAll();
            foreach (var prodCategory in productCategories) {
                editProduct.ProductCategoryList.Add(new SelectListItem(prodCategory.Description, prodCategory.Id.ToString()));
            }

            return View(model: editProduct);
        }

        // POST: /Product/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductEditDto product) {

            try {

                if (!ModelState.IsValid) {
                    return View();
                }

                var dbProduct = _productRepo.GetById(id);
                if (dbProduct == null) {
                    return NotFound();
                }

                dbProduct.Code = product.Code;
                dbProduct.Description = product.Description;
                dbProduct.Price = product.Price;
                dbProduct.Cost = product.Cost;
                dbProduct.ProductCategoryId = product.ProductCategoryId;

                _productRepo.Update(id, dbProduct);
                return RedirectToAction(nameof(Index));

            } catch {
                return View();
            }

        }

        // GET: /Product/Delete
        public ActionResult Delete(int id) {
            var dbProduct = _productRepo.GetById(id);
            if (dbProduct == null) {
                return NotFound();
            }

            var deleteProduct = new ProductDeleteDto {
                Id = dbProduct.Id,
                Code = dbProduct.Code,
                Description = dbProduct.Description,
                Price = dbProduct.Price,
                Cost = dbProduct.Cost
            };
            return View(model: deleteProduct);
        }

        // POST: /Product/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            _productRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Studio27SalonOfBeauty.Models.BindingModels;
using Studio27SalonOfBeauty.Models.EntityModels;
using Studio27SalonOfBeauty.Models.ViewModels.Products;

namespace Studio27SalonOfBeauty.Services
{
    public class ProductsService : Service
    {
        public IEnumerable<Product> GetAllCareLineProducts(string productCategory)
        {
            var products = this.Context.Products.Where(p => p.Category.ToString() == productCategory);
            return products;
        }

        public IEnumerable<Product> GetAllManProducts(string productCategory)
        {
            var products = this.Context.Products.Where(p => p.Category.ToString() == productCategory);
            return products;
        }

        public IEnumerable<Product> GetAllSoPureProducts(string productCategory)
        {
            var products = this.Context.Products.Where(p => p.Category.ToString() == productCategory);
            return products;
        }

        public IEnumerable<SubProduct> GetAllSubProducts(int? id)
        { 
            var products = this.Context.SubProducts.Where(p => p.ProductId== id);
            return products;
        }

        public void AddProductBindings(AddProductBinding productBM)
        {
            Product product = Mapper.Map<AddProductBinding, Product>(productBM);
            this.Context.Products.Add(product);
            this.Context.SaveChanges();
        }

        public void EditProduct(EditProductViewModel editProductVm)
        {
            var product = this.Context.Products.Find(editProductVm.Id);
            product.Name = editProductVm.Name;
            product.Description = editProductVm.Description;
            if (product == null)
            {
                throw new ArgumentException("Cannot find product with such id!");
            }
           
            this.Context.SaveChanges();
        }
    }
}

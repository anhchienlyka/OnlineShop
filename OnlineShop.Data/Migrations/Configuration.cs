namespace OnlineShop.Data.Migrations
{
    using Common;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using OnlineShop.Mode.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;
    internal sealed class Configuration : DbMigrationsConfiguration<OnlineShop.Data.OnlineShopDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
           
        }

        protected override void Seed(OnlineShop.Data.OnlineShopDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            DbContextSeed(context);
        }
        private void DbContextSeed(OnlineShopDBContext context, int retry = 0)
        {
            int retryForAvaiability = retry;
            try
            {
                CreateProductCategorySample(context);
            }
            catch (Exception)
            {
                if (retryForAvaiability < 10)
                {
                    retryForAvaiability++;

                    DbContextSeed(context, retryForAvaiability);
                }
            }
        }
        private void CreateProductCategorySample(OnlineShop.Data.OnlineShopDBContext context)
        {
            
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name="Điện lạnh",Alias="dien-lanh",CreateDate = DateTime.Now,Status =true },
                 new ProductCategory() { Name="Viễn thông",Alias="vien-thong",CreateDate = DateTime.Now,Status=true },
                  new ProductCategory() { Name="Đồ gia dụng",Alias="do-gia-dung",CreateDate = DateTime.Now,Status=true },
                   new ProductCategory() { Name="Mỹ phẩm",Alias="my-pham",CreateDate = DateTime.Now,Status=true },
                    new ProductCategory() { Name="Công nghệ",Alias="cong-nghe",CreateDate = DateTime.Now,Status=true }
            };

                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }

            if (context.ProductCategories.Any())
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
               
                    new ProductCategory() { Name="Môi trường",Alias="moi-truong",CreateDate = DateTime.Now,Status=true }
            };

                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
            if (context.ProductCategories.Any())
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {

                    new ProductCategory() { Name="Văn Hóa",Alias="van-hoa",CreateDate = DateTime.Now,Status=true }
            };

                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }

        }
    }
}

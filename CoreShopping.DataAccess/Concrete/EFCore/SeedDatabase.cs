using CoreShopping.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShopping.DataAccess.Concrete.EFCore
{
    public static class SeedDatabase
    {
        public static void Seed() // Eğer migration uygulanmamış ise aşağıdaki fake dataları oluşturur!!!!!! 
        {
            var context = new Context();

            if (context.Database.GetPendingMigrations().Count() == 0)//GetPendingMigrations ==> DB'ye uygulanmamış Migration sayısını verir
            {
                if (context.Categories.Count() == 0)
                {
                    //Category tek tek eklemek için
                    //Category c = new Category();
                    //c.Id = 12312;
                    //c.Name = "asdasd";
                    //Çoklu şekilde ekliyoruz
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategory);
                }

                context.SaveChanges();
            }

        }
        private static Category[] Categories =
        {
            new Category(){Name="Sci-Fi"},
            new Category(){Name="Action"},
            new Category(){Name="Commedy"},

        };
        private static Product[] Products =
        {
            new Product{ Name="John Wick 4",Description = "Kill with f*** pencil!!!",Price=300,
                Images={ new Image() { ImageUrl = "1.jpg" },new Image() { ImageUrl = "2.jpg" },new Image() { ImageUrl = "3.jpg" } }},
            new Product{ Name="Matrix 4",Description = "Neo comeback!!! (with Trinity)",Price=400,
                Images={new Image() { ImageUrl = "4.jpg" },new Image() { ImageUrl = "5.jpg" },new Image() { ImageUrl = "6.jpg" } }},
            new Product{ Name="Avangers 3",Description = "Heroes with pretty costumes",Price=500,
                Images={new Image() { ImageUrl = "7.jpg" },new Image() { ImageUrl = "8.jpg" },new Image() { ImageUrl = "9.jpg" } }},
            new Product{ Name="G.O.R.A",Description = "Halı,Kilim,Travel",Price=500,
                Images={new Image() { ImageUrl = "10.jpg" },new Image() { ImageUrl = "11.jpg" },new Image() { ImageUrl = "12.jpg" } }},
            new Product{ Name="Puss in Boots: The Last Wish",Description = "Cat with pretty boots",Price=800,
                Images={new Image() { ImageUrl = "13.jpg" },new Image() { ImageUrl = "14.jpg" },new Image() { ImageUrl = "15.jpg" } }}

        };

        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory(){Product=Products[0],Category=Categories[1]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[1]},
            new ProductCategory(){Product=Products[3],Category=Categories[2]},
            new ProductCategory(){Product=Products[4],Category=Categories[2]},
        };
    }
}

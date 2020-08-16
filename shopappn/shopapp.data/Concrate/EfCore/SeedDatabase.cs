using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrate.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context=new ShopContext();

            if(context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }
            }
            if(context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories=
        {
            new Category(){Name="Telefon"},
            new Category(){Name="Bilgisayar"},
            new Category(){Name="Elektronik"}
        };

        private static Product[] Products=
        {
            new Product(){Name="Samsung s5",Price=2000,ImageUrl="1.jpg",Description="İyi Telefon",IsApproved=true},
            new Product(){Name="Samsung s6",Price=2000,ImageUrl="2.jpg",Description="İyi Telefon",IsApproved=true},
            new Product(){Name="Samsung s7",Price=2000,ImageUrl="3.jpg",Description="İyi Telefon",IsApproved=true},
            new Product(){Name="Samsung s8",Price=2000,ImageUrl="4.jpg",Description="İyi Telefon",IsApproved=true},
            new Product(){Name="Samsung s9",Price=2000,ImageUrl="5.jpg",Description="İyi Telefon",IsApproved=true},

        };
        
    }
}
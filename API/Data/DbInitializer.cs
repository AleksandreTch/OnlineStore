using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if(context.Products.Any()) return;

            var products = new List<Product>
            {
// --------------------------------C-O-R-D-S---------------------------
                new Product
                {
                    Name = "iPhone Charging Cord",
                    Description = 
                        "Type C to lightning charging cord.",
                    Price = 2499,
                    PictureUrl = "/images/products/cord-01.png",
                    Brand = "Apple",
                    Type = "Accessories",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "iPhone Charging Cord",
                    Description = 
                        "Type A to lightning charging cord.",
                    Price = 2499,
                    PictureUrl = "/images/products/cord-02.png",
                    Brand = "Apple",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Samsung Charging Cord",
                    Description = 
                        "Type C to type C charging cord.",
                    Price = 2999,
                    PictureUrl = "/images/products/cord-03.png",
                    Brand = "Belkin",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Samsung Charging Cord",
                    Description = 
                        "Type A to type C charging cord.",
                    Price = 2999,
                    PictureUrl = "/images/products/cord-04.png",
                    Brand = "Belkin",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
// ---------------------------------A-D-A-P-T-E-R-S---------------------
                new Product
                {
                    Name = "iPhone dongle",
                    Description = 
                        "Aux to lightning adapter",
                    Price = 1999,
                    PictureUrl = "/images/products/dongle-01.png",
                    Brand = "Belkin",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Samsung dongle",
                    Description = 
                        "Aux to C adapter",
                    Price = 2999,
                    PictureUrl = "/images/products/dongle-02.png",
                    Brand = "Belkin",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
// ---------------------------------C-H-A-R-G-I-N-G--B-R-I-C-K-S--------
                new Product
                {
                    Name = "Apple Charging Brick",
                    Description = 
                        "Type C to Wall",
                    Price = 2499,
                    PictureUrl = "/images/products/brick-01.png",
                    Brand = "Apple",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Apple Charging Brick & The Cord",
                    Description = 
                        "Type C to Wall with type C to lightning cord",
                    Price = 4999,
                    PictureUrl = "/images/products/brick-02.png",
                    Brand = "Apple",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Samsung Chargin Brick ",
                    Description = 
                        "Type C to Wall",
                    Price = 1999,
                    PictureUrl = "/images/products/brick-03.png",
                    Brand = "Samsung",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Samsung Chargin Brick & The Cord ",
                    Description = 
                        "Type C to Wall with type c to type c",
                    Price = 4999,
                    PictureUrl = "/images/products/brick-04.png",
                    Brand = "Samsung",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
// ---------------------------------H-E-A-D-P-H-O-N-E-S-----------------
                new Product
                {
                    Name = "Aux Headphones",
                    Description = 
                        "Small compact earphones for everyday use",
                    Price = 2999,
                    PictureUrl = "/images/products/headphones-01.png",
                    Brand = "Skull Candy",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Aux Headphones",
                    Description = 
                        "Small compact earphones for everyday use",
                    Price = 4999,
                    PictureUrl = "/images/products/headphones-02.png",
                    Brand = "Skull Candy",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Aux Headphones",
                    Description = 
                        "Small compact earphones for everyday use",
                    Price = 1499,
                    PictureUrl = "/images/products/headphones-03.png",
                    Brand = "AKG",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Apple Aux Headphones",
                    Description = 
                        "Small compact earphones for everyday use",
                    Price = 1999,
                    PictureUrl = "/images/products/headphones-05.png",
                    Brand = "Apple",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Apple Lightning Headphones",
                    Description = 
                        "Small compact earphones for everyday use",
                    Price = 2999,
                    PictureUrl = "/images/products/headphones-06.png",
                    Brand = "Apple",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "Type C Headphones",
                    Description = 
                        "Small compact earphones for everyday use",
                    Price = 2999,
                    PictureUrl = "/images/products/headphones-07.png",
                    Brand = "Skullcandy",
                    Type = "Accessories",
                    QuantityInStock = 100  
                },
// ---------------------------------S-P-A-K-E-R-S-----------------------
                new Product
                {
                    Name = "JBL Clip 4",
                    Description = 
                        "Small speaker that you can take with you anywhere!",
                    Price = 9999,
                    PictureUrl = "/images/products/JBL-Clip-4.png",
                    Brand = "JBL",
                    Type = "Audio",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "JBL Charge 5",
                    Description = 
                        "Medium size speaker, perfect for the beach and indoors",
                    Price = 19999,
                    PictureUrl = "/images/products/JBL-Charge-5.png",
                    Brand = "JBL",
                    Type = "Audio",
                    QuantityInStock = 100  
                },
                new Product
                {
                    Name = "JBL Xtreme",
                    Description = 
                        "This speaker is a little large but the sub is worth it!",
                    Price = 31999,
                    PictureUrl = "/images/products/JBL-Xtreme.png",
                    Brand = "JBL",
                    Type = "Audio",
                    QuantityInStock = 100  
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}
using API.Entities;


namespace API.Data
{
    public static class DBInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Quantum Speedster Board 2000",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/sb-quantum1.png",
                    Brand = "Quantum",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Quantum Board 3000",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/sb-quantum2.png",
                    Brand = "Quantum",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nebula Board Speed Rush 3",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/sb-nebula1.png",
                    Brand = "Nebula",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nebula Super Board",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/sb-nebula2.png",
                    Brand = "Nebula",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pulsar Board Ultra Speed",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/sb-pulsar1.png",
                    Brand = "Pulsar",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Starlight Entry Board",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/sb-starlight1.png",
                    Brand = "Starlight",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nebula Blue Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/hat-nebula1.png",
                    Brand = "Nebula",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lunar Green Woolen Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/hat-lunar1.png",
                    Brand = "Lunar",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lunar Purple Woolen Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/hat-lunar2.png",
                    Brand = "Lunar",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orion Code Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/glove-orion1.png",
                    Brand = "Orion",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orion Green Code Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/glove-orion2.png",
                    Brand = "Orion",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lunar Purple Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/glove-lunar1.png",
                    Brand = "Lunar",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lunar Green Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/glove-lunar2.png",
                    Brand = "Lunar",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nova Red Boots",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/boot-nova1.png",
                    Brand = "Nova",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nebula Red Boots",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/boot-nebula1.png",
                    Brand = "Nebula",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nebula Purple Boots",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/boot-nebula2.png",
                    Brand = "Nebula",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Starlight Purple Boots",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/boot-starlight1.png",
                    Brand = "Starlight",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Starlight Blue Boots",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/boot-starlight2.png",
                    Brand = "Starlight",
                    Type = "Boots",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products){
                context.Products.Add(product);
            }

            context.SaveChanges();

        }
    }
}
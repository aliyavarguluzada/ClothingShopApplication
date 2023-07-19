using ClothingShopApplication.Data;
using ClothingShopApplication.Models;
ApplicationDbContext dbContext = new ApplicationDbContext();



Color color1 = new Color
{
    Name = "Qonur"
};

ProductCategory productCategory1 = new ProductCategory 
{ 
    Name = "Jeans"
};ProductCategory productCategory2 = new ProductCategory 
{ 
    Name = "T-Shirt"
};ProductCategory productCategory3 = new ProductCategory 
{ 
    Name = "Jacket"
};ProductCategory productCategory4 = new ProductCategory 
{ 
    Name = "Sneaker"
};
dbContext.Add(productCategory1);
dbContext.Add(productCategory2);
dbContext.Add(productCategory3);
dbContext.Add(productCategory4);
dbContext.SaveChanges();

Gender gender1 = new Gender { Name = "Men" };
Gender gender2 = new Gender { Name = "Women" };

dbContext.Genders.Add(gender1);
dbContext.Genders.Add(gender2);

dbContext.SaveChanges();


CategoryGender firstGender = new CategoryGender
{
    GenderId = 1,
    ProductCategoryId = 1,
};

dbContext.CategoryGenders.Add(firstGender);
dbContext.SaveChanges();



Product product = new Product
{
    Name = "Samba",
    Description = "dajsbdjkahshdk",
    Price = 1000,
    ShortDescription = "asdhaisd",
    ProductCategoryId = productCategory1.Id

};

dbContext.Products.Add(product);
dbContext.SaveChanges();

Comment comment1 = new Comment
{
    Content = "alksjdlk",
    Email = "ali@gmail.com",
    ProductId = product.Id
};

dbContext.Products.Add(product);
dbContext.Genders.Add(gender1);
dbContext.Genders.Add(gender2);
dbContext.Colors.Add(color1);

dbContext.SaveChanges();
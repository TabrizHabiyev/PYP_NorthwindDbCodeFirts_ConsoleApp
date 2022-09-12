using PYP_NorthwindCodeFirts.Models;
using PYP_NorthwindCodeFirtsProje.Models;

NORTHWNDContext context = new();

context.Categories.Add(new Category { CategoryName = "Example", Description = "Example" });


context.Categories.Update(new Category { CategoryId = 294, CategoryName = "Example", Description= "Example" });


Category category=context.Categories.FirstOrDefault(x => x.CategoryId == 294);


context.Categories.Remove(category);
context.SaveChanges();

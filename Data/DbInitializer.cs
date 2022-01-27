using EmployeeCapibilityDemonstration.Models;

namespace EmployeeCapibilityDemonstration.Data
{
    public static class DbInitializer
    {
        public static void Initializer(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Methods
            if (context.Methods.Any())
            {
                return;  // Yeah if having methods do nothing
            }

            var methods = new Method[]
            {
                new Method {Name = "504.1" },
                new Method {Name = "515.4" },
                new Method {Name = "508.1" },
                new Method {Name = "552.2" }

            };
            context.Methods.AddRange(methods);
            context.SaveChanges();

            var categories = new Category[]
            {
                new Category {Name = "Full Methhod" },
                new Category {Name = "Extract" },
                new Category {Name = "Analysis" }
                

            };
            context.Categories.AddRange(categories);
            context.SaveChanges();
        }
    }
}

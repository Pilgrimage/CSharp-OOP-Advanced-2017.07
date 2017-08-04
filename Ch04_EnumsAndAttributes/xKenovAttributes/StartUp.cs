namespace xKenovAttributes
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;

    public class StartUp
    {
        public static void Main()
        {
            // Get Author Attribute of Property "Name" of class "Cat"
            string name = typeof(Cat)
                .GetProperty("Name")
                .GetCustomAttribute<AuthorAttribute>()
                ?.Name;
            Console.WriteLine(name);

            // short
            Console.WriteLine(typeof(Cat)
                .GetProperty("Name")
                .GetCustomAttribute<AuthorAttribute>()
                ?.Name);


            // Get All Attributes of All properties in class "Cat"
            typeof(Cat)
                .GetProperties()
                .Select(pr => new
                {
                    Name = pr.Name,
                    Attrs = pr.GetCustomAttributes()
                })
                .ToList()
                .ForEach(pr => Console.WriteLine(pr.Name 
                    + ": " 
                    + string.Join(
                        ", ", 
                        pr.Attrs.Select(a => a.GetType().Name.Replace("Attribute", string.Empty)))));

        }
    }
}

namespace p01_HarvestingFieldsV2
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string input;
            Type classType = typeof(HarvestingFields);

            while ((input = Console.ReadLine()) != "HARVEST")
            {
                FieldInfo[] classFields = null;

                switch (input.ToLower())
                {
                    case "private":
                        classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.IsPrivate).ToArray();
                        break;

                    case "protected":
                        classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.IsFamily).ToArray(); ;
                        break;

                    case "public":
                        classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public);
                        break;

                    case "all":
                        classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        break;
                }

                PrintFields(classFields);
            }
        }

        private static void PrintFields(FieldInfo[] fields)
        {
            foreach (FieldInfo field in fields)
            {
                if (field.IsPublic)
                {
                    Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                }
                else if (field.IsPrivate)
                {
                    Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                }
                else if (field.IsFamily)
                {
                    Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                }
                else if (field.IsAssembly)
                {
                    Console.WriteLine($"internal {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}

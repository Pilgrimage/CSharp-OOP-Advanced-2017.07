namespace p01_HarvestingFieldsV2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            // State Solution

            Type HarvestingFieldsType = typeof(HarvestingFields);
            FieldInfo[] HarvestingFields = HarvestingFieldsType
                .GetFields(BindingFlags.Instance | BindingFlags.Static |
                           BindingFlags.NonPublic | BindingFlags.Public);

            Dictionary<string, Func<FieldInfo[]>> accModFilters = new Dictionary<string, Func<FieldInfo[]>>()
            {
                {"private", () => HarvestingFields.Where(f=>f.IsPrivate).ToArray()},
                {"protected", () => HarvestingFields.Where(f=>f.IsFamily).ToArray()},
                {"public", () => HarvestingFields.Where(f=>f.IsPublic).ToArray()},
                {"all", () => HarvestingFields}
            };

            FieldInfo[] gatheredFields = null;
            string input;

            while ((input = Console.ReadLine()) != "HARVEST")
            {
                gatheredFields = accModFilters[input]();

                string[] result = gatheredFields
                    .Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
                    .ToArray();

                Console.WriteLine(string.Join(Environment.NewLine, result).Replace("family", "protected"));

                // One-line solution
                //accModFilters[input]()
                //    .Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
                //    .ToList()
                //    .ForEach(r => Console.WriteLine(r.Replace("family", "protected")));
            }
        }

    }
}

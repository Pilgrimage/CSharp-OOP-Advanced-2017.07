namespace p02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class BlackBoxIntegerTests
    {
        private StringBuilder sb;

        public BlackBoxIntegerTests()
        {
            this.sb = new StringBuilder();
        }

        public string Run(Type type)
        {
            object classInstance = Activator.CreateInstance(type, true);
            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo field = fields[0];

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] inParams = input.Split('_');
                string command = inParams[0];
                int commandArg = int.Parse(inParams[1]);
                MethodInfo method = typeof(BlackBoxInt).GetMethod(command, BindingFlags.Instance | BindingFlags.Static | 
                                                                           BindingFlags.Public | BindingFlags.NonPublic);

                method?.Invoke(classInstance, new object[] { commandArg });

                this.sb.AppendLine(field.GetValue(classInstance).ToString());
            }

            return this.sb.ToString().Trim();
        }
    }
}

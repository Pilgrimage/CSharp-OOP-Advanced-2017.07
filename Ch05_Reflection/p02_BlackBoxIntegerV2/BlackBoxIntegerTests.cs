namespace p02_BlackBoxIntegerV2
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            // State solution
             const BindingFlags NonPublicFlags = BindingFlags.Instance | BindingFlags.NonPublic;

            Type blackBoxType = typeof(BlackBoxInt);

            // Next work with ziro constructor
            BlackBoxInt myBlackBox = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);
            
            // Another way
            //ConstructorInfo blackBoxCtor = blackBoxType.GetConstructor(NonPublicFlags, Type.DefaultBinder, new Type[] { }, null);

            string input = null;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] inParams = input.Split('_');
                string methodName = inParams[0];
                int methodArg = int.Parse(inParams[1]);

                blackBoxType.GetMethod(methodName, NonPublicFlags).Invoke(myBlackBox, new object[] {methodArg});

                object innetrStateValue = blackBoxType.GetFields(NonPublicFlags).First().GetValue(myBlackBox);

                Console.WriteLine(innetrStateValue);
            }
        }
    }
}

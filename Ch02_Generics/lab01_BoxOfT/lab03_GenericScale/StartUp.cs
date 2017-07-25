using System;

public class StartUp
{
    public static void Main()
    {
        Scale<String> stringScale = new Scale<String>("a", "c");
        var result1 = stringScale.GetHavier();
        if (result1!=null)
        {
            Console.WriteLine(result1);
        }

        Scale<Int32> intScale = new Scale<Int32>(1, 2);
        var result2 = intScale.GetHavier();
        if (result2 != null)
        {
            Console.WriteLine(result2);
        }

    }
}

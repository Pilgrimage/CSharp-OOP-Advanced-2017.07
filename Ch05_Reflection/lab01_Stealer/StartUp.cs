using System;

public class StartUp
{
    public static void Main()
    {
        Spy spy = new Spy();

        // lab01_Stealer
        //string result = spy.StealFieldInfo("Hacker", "username", "password");

        // lab02_HighQualityMistakes
        //string result = spy.AnalyzeAcessModifiers("Hacker");

        // lab03_MissionPrivateImpossible
        //string result = spy.RevealPrivateMethods("Hacker");

        // lab04_Collector
        string result = spy.CollectGettersAndSetters("Hacker");


        Console.WriteLine(result);
    }
}


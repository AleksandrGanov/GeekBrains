// Виртуальный метод

using System;

public class Animals
{
    public virtual string DisplayFirstWay()
    {
        return $"I am a {nameof(Animals)} class method";
    }

    public virtual string DisplaySecondWay()
    {
        return $"I am a {nameof(Animals)} class method";
    }

    public virtual string DisplayThirdWay()
    {
        return $"I am a {nameof(Animals)} class method";
    }
}

public class Cat : Animals
{
    public override string DisplaySecondWay()
    {
        return $"I am a {nameof(Cat)} class method";
    }

    public new string DisplayThirdWay()
    {
        return $"I am a {nameof(Cat)} class method";
    }
}

public class Program
{
    public static void Main()
    {
        Animals animals = new Animals();
        Console.WriteLine(animals.DisplayFirstWay());
        Console.WriteLine(animals.DisplaySecondWay());
        Console.WriteLine(animals.DisplayThirdWay());
        Console.WriteLine("");

        Animals animals1 = new Cat();
        Console.WriteLine(animals1.DisplayFirstWay());
        Console.WriteLine(animals1.DisplaySecondWay());
        Console.WriteLine(animals1.DisplayThirdWay());
        Console.WriteLine("");

        Cat animals2 = new Cat();
        Console.WriteLine(animals2.DisplayFirstWay());
        Console.WriteLine(animals2.DisplaySecondWay());
        Console.WriteLine(animals2.DisplayThirdWay());

        Console.ReadLine();
    }
}
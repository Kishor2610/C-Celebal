using System;

class Program5
{
    public static void Main(string[] args)
    {
        string f1 = "Frank";
        string f2 = "Alice";
        string f3 = "Bob";

        GreetFriend(f1);
        GreetFriend(f2);
        GreetFriend(f3);
    }

    static void GreetFriend(string friendName)
    {
        Console.WriteLine("Hi " + friendName + ", my friend!");
    }
}

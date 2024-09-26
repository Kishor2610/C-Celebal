using System;
class Program2
{
    public static void Main(string[] args)
    {
        string inputString;

        Console.WriteLine("Please enter your name and press enter: ");
        inputString = Console.ReadLine();

        // Convert the string to uppercase
        string uppercaseString = inputString.ToUpper();
        Console.WriteLine("Uppercase: " + uppercaseString);

        // Convert the string to lowercase
        string lowercaseString = inputString.ToLower();
        Console.WriteLine("Lowercase: " + lowercaseString);

        // Remove trailing and leading white spaces
        string trimmedString = inputString.Trim();
        Console.WriteLine("Trimmed: " + trimmedString);

        // Display a substring (e.g., first 3 characters)
        int substringLength = 5;
        string substring = inputString.Substring(0, Math.Min(substringLength, inputString.Length));
        Console.WriteLine("Substring: " + substring);
    }
}

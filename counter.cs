using System;

class CharacterCounter
{
    static void Main()
    {
        Console.Write("Enter the desired string or value: ");
        string inputString = Console.ReadLine();

        // Initialize counts for each category
        int uppercaseCount = 0, lowercaseCount = 0, digitCount = 0, spaceCount = 0, specialCharCount = 0;

        // Count characters in the input string
        foreach (char character in inputString)
        {
            if (char.IsUpper(character))
                uppercaseCount++;
            else if (char.IsLower(character))
                lowercaseCount++;
            else if (char.IsDigit(character))
                digitCount++;
            else if (char.IsWhiteSpace(character))
                spaceCount++;
            else
                specialCharCount++;
        }

        // Display the results
        Console.WriteLine($"The number of uppercase letters is {uppercaseCount}");
        Console.WriteLine($"The number of lowercase letters is {lowercaseCount}");
        Console.WriteLine($"The number of digits is {digitCount}");
        Console.WriteLine($"The number of spaces is {spaceCount}");
        Console.WriteLine($"The number of special characters is {specialCharCount}");
    }
}

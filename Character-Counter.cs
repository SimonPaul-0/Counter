using System;

class CharacterCounter
{
    static void Main()
    {
        Console.Write("Enter the desired string or value: ");
        string inputString = Console.ReadLine();

        // Initialize counts for each category
        int totalCharacters = 0;
        int uppercaseCount = 0;
        int lowercaseCount = 0;
        int digitCount = 0;
        int spaceCount = 0;
        int specialCharCount = 0;

        // Count characters in the input string
        foreach (char character in inputString)
        {
            // Increment total character count
            totalCharacters++;

            // Check the character type and update the corresponding count
            if (char.IsUpper(character))
            {
                uppercaseCount++;
            }
            else if (char.IsLower(character))
            {
                lowercaseCount++;
            }
            else if (char.IsDigit(character))
            {
                digitCount++;
            }
            else if (char.IsWhiteSpace(character))
            {
                spaceCount++;
            }
            else
            {
                specialCharCount++;
            }
        }

        // Display the results
        Console.WriteLine($"Total characters in the input string: {totalCharacters}");
        Console.WriteLine($"The number of uppercase letters is {uppercaseCount} ({CalculatePercentage(uppercaseCount, totalCharacters)}%)");
        Console.WriteLine($"The number of lowercase letters is {lowercaseCount} ({CalculatePercentage(lowercaseCount, totalCharacters)}%)");
        Console.WriteLine($"The number of digits is {digitCount} ({CalculatePercentage(digitCount, totalCharacters)}%)");
        Console.WriteLine($"The number of spaces is {spaceCount} ({CalculatePercentage(spaceCount, totalCharacters)}%)");
        Console.WriteLine($"The number of special characters is {specialCharCount} ({CalculatePercentage(specialCharCount, totalCharacters)}%)");
    }

    // Helper method to calculate the percentage
    static double CalculatePercentage(int count, int total)
    {
        return (count * 100.0) / total;
    }
}

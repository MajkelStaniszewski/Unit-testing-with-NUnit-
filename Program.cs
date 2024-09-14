using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


class WordCounter
{
    static void Main()
    {
        // Path to the text file
        string filePath = @"C:\Users\stani\Desktop\app\text.txt";
        
        try
        {
            // Read all the text from the file
            string text = File.ReadAllText(filePath);

            // Split text into words using Regex to handle all non-word characters and convert to lower case for uniformity
            string[] words = Regex.Split(text, @"\W+")
                                  .Where(word => !string.IsNullOrWhiteSpace(word)) // Filter out any empty entries
                                  .Select(word => word.ToLower()) // Convert each word to lower case
                                  .ToArray();

            // Create a dictionary to store word counts
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            // Count occurrences of each word
            foreach (string word in words)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            // Display the word counts
            foreach (KeyValuePair<string, int> kvp in wordCounts)
            {
                Console.WriteLine($"{kvp.Value}: {kvp.Key}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}




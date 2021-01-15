using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        private static int value;
        private static object index;

        /*
Welcome to Interation

In each method below you will see instructions that detail the requirements
the method must implement to make the test pass.

To start on a method comment out, or remove, the line
`throw new System.NotImplementedException();`

As you write and save your code, you can look in your terminal where you
ran `dotnet watch test` to see if your code is working. The tests
continuously check your work each time you save. If a test is failing
you have not yet completed that method. Once you finish a method and have
it correct, the test will tell you how the next method is working.
*/


        //  
        // 1) Complete the method named `yelling` that takes a list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var upperCaseWords = words.Select(word => word.ToUpper());
            return upperCaseWords;
        }


        // 
        // 2) Complete the method named `Double` that takes a list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            var numberDouble = numbers.Select(number => number * 2);
            return numberDouble;
        }


        // 
        // 3) Complete the method `StringyIndexes` that takes a list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> words)
        {
            var newWords = words.Select((word, index) => $"{word} is at index {index}");
            return newWords;


        }


        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts a list of
        //    numbers and returns only the elements that are even.

        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> numbers)
        {
            // need to use where statement to pull out even number from list
            var onlyEvenNumbers = numbers.Where(number => number % 2 == 0);
            return onlyEvenNumbers;
        }


        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts a
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> numbers)
        {
            var onlyEvenNumbers = numbers.Where((number, index) => index % 2 == 0);
            return onlyEvenNumbers;
        }


        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts a list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        // 
        // A movie object looks like this:
        // 
        // new Movie() {
        //   Name: "Get Out",
        //   Year: "2017",
        //   Score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> movies, int yearToMatch)
        {
            var BestMoviesOfTheYear = movies.Where(movie => movie.Score > 90 && movie.Year == yearToMatch);
            var nameBestMovieOfTheYear = BestMoviesOfTheYear.Select(movies => movies.Name);
            return nameBestMovieOfTheYear;
        }
        // 
        // 
        // 7) Complete the method EveryoneIsOdd that accepts a list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> numbers)
        {
            var EveryoneIsOdd = numbers.All(number => number % 2 != 0);
            return EveryoneIsOdd;
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts a list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> sentences)
        {
            //    given a list of sentences. go through each sentence 
            var FindTheNeedle = sentences.First(sentence => sentence.Contains("needle"));
            // does the string CONTAIN the word Needle
            // var containsNeedle = sentences.Contains('needle');
            // return string with word NEEDLE
            return FindTheNeedle;
        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts a list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> sentences)
        {
            // Given a list, find the word Needle
            var findTheNeedleIndex = sentences.FindIndex(sentence => sentence.Contains("needle"));
            //  Find the index containing Needle

            //  Return the index containing Needle
            return findTheNeedleIndex;
        }


        // 
        // 10) Complete the method SomeoneToLove that accepts a list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> words)
        {
            // Given a LIST of Strings count number of characters
            var SomeoneToLove = words.Any(word => word.Length == 4);
            // If string equals 4 characters return true
            return SomeoneToLove;

        }
    }
}

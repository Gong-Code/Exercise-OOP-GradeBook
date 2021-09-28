using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book2 = new Book("Grade Book");
            book2.AddGrade(89.1);
            book2.AddGrade(90.5);
            book2.AddGrade(77.5);

            var stats = book2.GetStatistics();//skapar en variabel för "Refactoring" för designa ny kod (förbättra läsbarheten).

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            // i min book vill 

        }
    }
}

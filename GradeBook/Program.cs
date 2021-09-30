using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Grade Book");
            Console.WriteLine("Grades Book");
            Console.WriteLine("-----------");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;

                }


                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            var stats = book.GetStatistics();//skapar en variabel för "Refactoring" för designa ny kod (förbättra läsbarheten).

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");


        }
    }
}

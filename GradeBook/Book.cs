using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades; //Skapar en lista med betyg

        public string Name;

        public Book(string name) // Stoppar in grades och name i konstruktor
        {
            grades = new List<double>();
            Name = name;
        }

        public Statistics GetStatistics()//Denna metod returnerar classen Statistics
        {
            var result = new Statistics();// skapar en ny objekt av Statistics i metoden, använder result variabel.
            result.Average = 0.0;
            result.High = double.MinValue;// skapar variabel för att hitta högsta betyg.
            result.Low = double.MaxValue;// skapar variabel för att hitta lägsta betyg.


            for (int index = 0; index < grades.Count; index++)
            {
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
            }


            result.Average /= grades.Count; //medelvärdet av betyget.

            switch (result.Average)
            {
                case var setGradeLetter when setGradeLetter >= 90.0:
                    result.Letter = 'A';
                    break;

                case var setGradeLetter when setGradeLetter >= 80.0:
                    result.Letter = 'B';
                    break;

                case var setGradeLetter when setGradeLetter >= 70.0:
                    result.Letter = 'C';
                    break;

                case var setGradeLetter when setGradeLetter >= 60.0:
                    result.Letter = 'D';
                    break;
                
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 || grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public void AddLetterGrade(char letter)//Sätter betyget med bokstäver beroende på resultat
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }
    }
}

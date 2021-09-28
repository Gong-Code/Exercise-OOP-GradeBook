using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades; //Skapar en lista med betyg

        private string Name;

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
            
            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade; 
            }
            result.Average /= grades.Count; //medelvärdet av betyget.

            return result;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}

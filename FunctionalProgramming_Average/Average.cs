using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming_Average
{
    class Average
    {
        public Average()
        {

        }
        public delegate int Grades(string grades);
        public Grades operateGrades;

        public void GetAverageGrade()
        {
            string grades = "90,100,82,89,55";

            List<int> final = new List<int>();

            int gradeInt;
            var gradesAsInt = grades.Split(new[] { ',' })
                .Select(gradesAsString => int.TryParse(gradesAsString, out gradeInt) ? gradeInt : 0).ToList()
                .OrderBy(gradeValues => gradeValues).Skip(3);

            double averageGrade = gradesAsInt.Average();

            Console.WriteLine("Final Average of two highest grades: " + averageGrade);
            Console.ReadLine();
        }
    }
}

//Write a function that takes in a string of grades(e.g., "90,100,82,89,55"), 
//and returns an average (add #'s and divide by how many #'s) of all but the lowest three grades(e.g., "90,100" => 95).
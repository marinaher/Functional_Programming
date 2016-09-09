using System.Collections.Generic;

namespace Functional_Programming_Average
{
    class Average
    {
        public Average()
        {

        }
        public delegate int Grades(string grades);                  //define delegate type
        public Grades operateGrades;                                //create instance of delegate

        public int AverageGrades(string average)                    //method to convert string literale to ints
        {
            int total = 0;
            List<int> final = new List<int>();
            foreach (var i in average.Split(','))
            {
                int gradeNumber;
                if (int.TryParse(i, out gradeNumber))
                {
                    final.Add(gradeNumber);
                }
            }
            final.Sort();
            for (int j = 3; j < final.Count; j++)
            {
                total = total + final[j];
            }
            total = total / (final.Count - 3);
            return total;
        }
    }
}

//Write a function that takes in a string of grades(e.g., "90,100,82,89,55"), 
//and returns an average (add #'s and divide by how many #'s) of all but the lowest three grades(e.g., "90,100" => 95).

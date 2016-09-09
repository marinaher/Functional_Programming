using System;

namespace Functional_Programming_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradesString = "90,100,82,89,55";                                                 //string literale

            Average funcProgramAssignment = new Average();                                           //instantiate new FuncProgramAssignment

            funcProgramAssignment.operateGrades = (string y) => { return funcProgramAssignment.AverageGrades(y); };

            Console.WriteLine("Average (of all but the lowest three grades): \t" + funcProgramAssignment.operateGrades(gradesString));
            Console.ReadLine();
        }
    }
}

using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        List<double> grades;
    }
}
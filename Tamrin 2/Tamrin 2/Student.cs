using AbstractPerson;
using StudentCourseObject;
using System.Diagnostics.CodeAnalysis;

namespace StudentObject;

public class Student : Person
{
    public string StudentNumber { get; set; }
    public List<StudentCourse> CoursesTaken { get; set; } = new();

    public Student(string firstName, string lastName, string nationalCode, string studentNumber)

    : base(firstName, lastName, nationalCode)
    {
        StudentNumber = studentNumber;
    }

    public double GetAverage()
    {
        double sum = 0;
        int count = 0;

        for (int i = 0; i < CoursesTaken.Count; i++) {
            if (CoursesTaken[i].Grade.HasValue) {
                sum += CoursesTaken[i].Grade.Value;
                count++;
            }
        }
        if (count == 0) return 0;
        return sum / count;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Student Number: {StudentNumber}";
    }
}

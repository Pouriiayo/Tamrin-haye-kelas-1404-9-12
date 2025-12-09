using AbstractPerson;
using CourseObject;

namespace TeacherObject;

public class Teacher : Person
{
    public string TeacherCode { get; set; }
    public List<Course> CourseTeach { get; set; } = new();

    public Teacher(string firstName, string lastName, string nationalCode, string teacherCode) 

    : base(firstName, lastName, nationalCode)
    {
        TeacherCode = teacherCode;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Teacher Code: {TeacherCode}";
    }
}

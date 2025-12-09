namespace CourseObject;

public class Course
{
    public string CourseName { get; set; }
    public int Units { get; set; }

    public Course(string courseName, int units)
    {
        CourseName = courseName;
        Units = units;
    }

    public override string ToString()
    {
        return $"{CourseName} ({Units} units)";
    }

}

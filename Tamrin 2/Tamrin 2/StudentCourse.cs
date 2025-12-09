using CourseObject;
using TeacherObject;

namespace StudentCourseObject;

public class StudentCourse
{
    public Course Course { get; set; }
    public Teacher Teacher { get; set; }
    public double? Grade { get; set; }

    public StudentCourse(Course course, Teacher teacher)
    {
        Course = course;
        Teacher = teacher;
    }
}

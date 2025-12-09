using AbstractPerson;
using CourseObject;
using StudentCourseObject;
using StudentObject;
using System.Runtime.InteropServices.Marshalling;
using TeacherObject;

Teacher t1 = new Teacher("Ali", "Hafezi", "1234567890", "T1001");
Teacher t2 = new Teacher("Sara", "Karimi", "0987654321", "T1002");

Course math = new Course("Math", 3);
Course oop = new Course("OOP", 2);

t1.CourseTeach.Add(oop);
t2.CourseTeach.Add(math);

Student s1 = new Student("Pouria", "Yousefi", "0928685731", "S1001");

s1.CoursesTaken.Add(new StudentCourse(math, t2));
s1.CoursesTaken.Add(new StudentCourse(oop, t1));

s1.CoursesTaken[0].Grade = 18.5;
s1.CoursesTaken[1].Grade = 16;

Console.WriteLine(s1);
foreach (var item in s1.CoursesTaken)
{
    Console.WriteLine($"{item.Course.CourseName} with {item.Teacher.FullName}");
}

Console.WriteLine($"\nAverage: {s1.GetAverage()}");
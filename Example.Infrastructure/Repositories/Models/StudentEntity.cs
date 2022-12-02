using Example.Application.Students;

namespace Example.Infrastructure.Repositories.Models;

internal record StudentEntity(string FirstName, string LastName,  IEnumerable<CourseEntity> Courses)
{
    public static explicit operator StudentEntity(Student student)
    => new(student.FirstName, student.LastName, student.Courses.Select(c => (CourseEntity)c));

    public static explicit operator Student(StudentEntity entity)
    => new(entity.FirstName, entity.LastName, entity.Courses.Select(c => (Course)c));
}

internal record CourseEntity(string Name, double Grade)
{
    public static explicit operator CourseEntity(Course course)
        => new(course.Name, course.Grade);

    public static explicit operator Course(CourseEntity entity)
        => new(entity.Name, entity.Grade);
}
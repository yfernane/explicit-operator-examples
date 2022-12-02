using Example.Application.Students.Queries.Projections;

namespace Example.Infrastructure.Projections.Models;

internal record DbStudent(Guid Id, string FirstName, string LastName,  IEnumerable<DbCourse> Courses)
{
    public static explicit operator GetStudentProjection(DbStudent student)
        => new(student.Id, student.FirstName, student.LastName, student.Courses.Select(c => (GetCourseProjection)c));
}

internal record DbCourse(Guid Id, string Name, double Grade)
{
    public static explicit operator GetCourseProjection(DbCourse course)
        => new(course.Id, course.Name, course.Grade);
}
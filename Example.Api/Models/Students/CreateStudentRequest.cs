using Example.Application.Students;

namespace Example.Api.Models.Students;

public record CreateStudentRequest(string FirstName, string LastName, CreateCourseRequest[] Courses)
{
    public static explicit operator Student(CreateStudentRequest request)
        => new(request.FirstName, request.LastName, request.Courses.Select(c => (Course)c));
}

public record CreateCourseRequest(string Name, double Grade)
{
    public static explicit operator Course(CreateCourseRequest request)
        => new(request.Name, request.Grade);
}
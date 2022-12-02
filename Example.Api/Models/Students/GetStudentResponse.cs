using Example.Application.Students.Queries.Projections;

namespace Example.Api.Models.Students;

public record GetStudentResponse(Guid Id, string FirstName, string LastName, IEnumerable<GetCourseResponse> Courses)
{
    public static implicit operator GetStudentResponse(GetStudentProjection projection)
        => new(projection.Id, projection.FirstName, projection.LastName, projection.Courses.Select(c => (GetCourseResponse)c));
}

public record GetCourseResponse(Guid Id, string Name, double Grade)
{
    public static implicit operator GetCourseResponse(GetCourseProjection projection)
        => new(projection.Id, projection.Name, projection.Grade);
}
namespace Example.Application.Students.Queries.Projections;

public record GetStudentProjection(Guid Id, string FirstName, string LastName,  IEnumerable<GetCourseProjection> Courses);

public record GetCourseProjection(Guid Id, string Name, double Grade);
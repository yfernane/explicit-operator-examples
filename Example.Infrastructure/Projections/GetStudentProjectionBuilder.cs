using Example.Application.Students.Queries;
using Example.Application.Students.Queries.Projections;
using Example.Infrastructure.Projections.Models;

namespace Example.Infrastructure.Projections;

public class GetStudentProjectionBuilder : IGetStudentProjectionBuilder
{
    public Task<GetStudentProjection> GetStudentAsync(Guid id, CancellationToken cancellationToken)
    {
        // Imagine some retrieving from a database of the DbStudent
        var retrievedStudent = new DbStudent(
            Guid.NewGuid(),
            "Michael",
            "Scott",
            new[] {
                new DbCourse(Guid.NewGuid(), "Mathematic", 9),
                new DbCourse(Guid.NewGuid(), "History", 17),
                new DbCourse(Guid.NewGuid(), "AutoMapping", 0),
            });

        return Task.FromResult((GetStudentProjection)retrievedStudent);
    }
}
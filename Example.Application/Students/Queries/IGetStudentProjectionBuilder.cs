using Example.Application.Students.Queries.Projections;

namespace Example.Application.Students.Queries;

public interface IGetStudentProjectionBuilder
{
    Task<GetStudentProjection> GetStudentAsync(Guid id, CancellationToken cancellationToken);
}
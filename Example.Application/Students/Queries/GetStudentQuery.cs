using Example.Application.Students.Queries.Projections;
using MediatR;

namespace Example.Application.Students.Queries;

public record GetStudentQuery(Guid Id) : IRequest<GetStudentProjection>;
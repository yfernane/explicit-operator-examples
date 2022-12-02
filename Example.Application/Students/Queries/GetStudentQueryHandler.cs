using Example.Application.Students.Queries.Projections;
using MediatR;

namespace Example.Application.Students.Queries;

public class GetStudentQueryHandler : IRequestHandler<GetStudentQuery, GetStudentProjection>
{
    private readonly IGetStudentProjectionBuilder studentProjectionBuilder;

    public GetStudentQueryHandler(IGetStudentProjectionBuilder studentProjectionBuilder)
    {
        this.studentProjectionBuilder = studentProjectionBuilder;
    }

    public Task<GetStudentProjection> Handle(GetStudentQuery request, CancellationToken cancellationToken)
        => studentProjectionBuilder.GetStudentAsync(request.Id, cancellationToken);
}

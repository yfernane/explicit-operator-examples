using Example.Application.Interfaces;
using MediatR;

namespace Example.Application.Students.Commands;

public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Guid>
{
    private readonly IStudentRepository studentRepository;

    public CreateStudentCommandHandler(IStudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
    }

    public Task<Guid> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        => studentRepository.CreateStudentAsync(request.Student, cancellationToken);
}
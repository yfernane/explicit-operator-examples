using MediatR;

namespace Example.Application.Students.Commands;

public record CreateStudentCommand(Student Student) : IRequest<Guid>;

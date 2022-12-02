using Example.Application.Students;

namespace Example.Application.Interfaces;

public interface IStudentRepository
{
    Task<Guid> CreateStudentAsync(Student student, CancellationToken cancellationToken);
}
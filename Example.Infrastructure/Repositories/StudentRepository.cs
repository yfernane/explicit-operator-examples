using Example.Application.Interfaces;
using Example.Application.Students;
using Example.Infrastructure.Repositories.Models;

namespace Example.Infrastructure.Repositories;

public class StudentRepository : IStudentRepository
{
    public Task<Guid> CreateStudentAsync(Student student, CancellationToken cancellationToken)
    {
        var entity = (StudentEntity)student;
        // Imagine some SQL or in memory task to store the student

        return Task.FromResult(Guid.NewGuid());
    }
}
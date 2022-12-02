using Example.Application.Interfaces;

namespace Example.Application.Students;

public record Student(string FirstName, string LastName,  IEnumerable<Course> Courses) : IAggregateRoot;

public record Course(string Name, double Grade);
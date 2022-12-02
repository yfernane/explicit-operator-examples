using Example.Api.Models.Students;
using Example.Application.Students;
using Example.Application.Students.Commands;
using Example.Application.Students.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Example.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Consumes(MediaTypeNames.Application.Json)]
[Produces(MediaTypeNames.Application.Json)]
public class StudentController : ControllerBase
{
    private readonly IMediator mediator;

    public StudentController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpPost(Name = "CreateStudent")]
    [ProducesDefaultResponseType]
    [ProducesResponseType(typeof(CreateStudentResponse), StatusCodes.Status201Created)]
    public async Task<IActionResult> CreateStudentAsync(CreateStudentRequest request)
    {
        var studentId = await mediator.Send(new CreateStudentCommand((Student)request));

        return Created("GetStudent", new CreateStudentResponse(studentId));
    }

    [HttpGet("{id:guid}", Name = "GetStudent")]
    [ProducesDefaultResponseType]
    [ProducesResponseType(typeof(GetStudentResponse), StatusCodes.Status201Created)]
    public async Task<IActionResult> GetStudent([FromRoute] Guid id)
    {
        var student = await mediator.Send(new GetStudentQuery(id));

        return Created("GetStudent", (GetStudentResponse)student);
    }
}
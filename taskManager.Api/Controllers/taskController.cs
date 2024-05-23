using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taskManager.application.UseCase.task.Delete;
using taskManager.application.UseCase.task.GetAll;
using taskManager.application.UseCase.task.GetById;
using taskManager.application.UseCase.task.Register;
using taskManager.application.UseCase.task.Update;
using taskManager.Communication.Requests;
using taskManager.Communication.Responses;

namespace taskManager.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class taskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(RespondeRegisteredTask) , StatusCodes.Status201Created)]
    public IActionResult RegisterTask( RequestRegisterTaskJson request)
    {
        var useCase = new RegisterTaskUseCase();
        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasksJson) , StatusCodes.Status200OK)]
    public IActionResult GetAllTasks()
    {
        var useCase = new GetAllTasksUseCase();

        var response = useCase.Execute();

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateTask( [FromRoute] int id , [FromBody] RequestRegisterTaskJson request )
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson) , StatusCodes.Status200OK)]
    public IActionResult GetTaskById( [FromRoute] int id )
    {
        var useCase = new GetTaskByIdUseCase();
        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteTask( [FromRoute] int id )
    {
        var useCase = new DeleteTaskUseCase();
        useCase.Execute(id);


        return NoContent();
    }

}

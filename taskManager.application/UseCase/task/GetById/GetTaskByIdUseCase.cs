using taskManager.Communication.Enums;
using taskManager.Communication.Responses;

namespace taskManager.application.UseCase.task.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id ,
            Name = "name teste" ,
            Description = "Descricao de teste" ,
            priority = Priority.high,
            dateLimit = DateTime.Now,
            status = Status.Progress,
        };
    }
}


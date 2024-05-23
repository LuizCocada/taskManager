using taskManager.Communication.Requests;
using taskManager.Communication.Responses;

namespace taskManager.application.UseCase.task.Register;

public class RegisterTaskUseCase
{
    public RespondeRegisteredTask Execute( RequestRegisterTaskJson request )
    {
        return new RespondeRegisteredTask
        {
            Id = request.Id ,
            Name = request.Name ,
        };
    }
}


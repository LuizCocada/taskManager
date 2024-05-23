using System.Threading.Tasks;
using taskManager.Communication.Responses;

namespace taskManager.application.UseCase.task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortTaskJson> 
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Nome Tarefa Teste",
                }
            }
        };
    }
}


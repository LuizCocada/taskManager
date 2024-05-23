using taskManager.Communication.Enums;

namespace taskManager.Communication.Requests;

public class RequestRegisterTaskJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Priority priority { get; set; }

    public DateTime dateLimit { get; set; }

    public Status status { get; set; }
}


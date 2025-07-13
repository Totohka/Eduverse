using Eduverse.Model.Entities.Bases;

namespace Eduverse.Model.Entities.BankTasks;

public class AnswerCheck : BaseEntity
{
    public Guid QuestionUid { get; set; }
    public Question Question { get; set; }
    public string Text { get; set; }
    public bool IsRight { get; set; }
}

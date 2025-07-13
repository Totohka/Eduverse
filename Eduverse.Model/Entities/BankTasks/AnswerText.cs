using Eduverse.Model.Entities.Bases;

namespace Eduverse.Model.Entities.BankTasks;

public class AnswerText : BaseEntity
{
    public Guid QuestionUid { get; set; }
    public Question Question { get; set; }
    public string Text { get; set; }
}

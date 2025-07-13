using Eduverse.Model.Entities.Bases;

namespace Eduverse.Model.Entities.BankTasks;

public class AnswerAccordance : BaseEntity
{
    public Guid QuestionUid { get; set; }
    public Question Question { get; set; }
    public string Text { get; set; }

    /// <summary>
    /// В левой колонке?
    /// </summary>
    public bool Left { get; set; }

    /// <summary>
    /// С каким ответом связан
    /// </summary>
    public Guid AnswerAccordanceLinkUid { get; set; }
    public AnswerAccordance AnswerAccordanceLink { get; set; }
}

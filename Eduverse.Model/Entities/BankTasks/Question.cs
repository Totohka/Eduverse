using Eduverse.Model.Entities.Bases;
using Eduverse.Model.Enums;

namespace Eduverse.Model.Entities.BankTasks;

public class Question : BaseEntity
{
    public Guid? BankTestUid { get; set; }
    public BankTest? BankTest { get; set; }
    public Guid? BankModuleUid { get; set; }
    public BankModule? BankModule { get; set; }
    public string Text { get; set; }
    public QuestionTypes QuestionTypes { get; set; }
    public HashSet<AnswerCheck>? AnswerChecks { get; set; }
    public HashSet<AnswerAccordance>? AnswerAccordances { get; set; }
    public HashSet<AnswerRadio>? AnswerRadios { get; set; }
    public HashSet<AnswerText>? AnswerTexts { get; set; }
}

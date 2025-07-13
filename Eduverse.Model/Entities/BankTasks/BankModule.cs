using Eduverse.Model.Entities.Bases;
using System.Reflection;

namespace Eduverse.Model.Entities.BankTasks;

public class BankModule : BaseEntity
{
    public Guid BankUid { get; set; }
    public Bank Bank { get; set; }
    public Guid ModuleUid { get; set; }
    public Module Module { get; set; }
    public HashSet<Question> Questions { get; set; }
}

using Eduverse.Model.Entities.Bases;
using Eduverse.Model.Entities.ZeroCode;

namespace Eduverse.Model.Entities.BankTasks;

public class BankTest : BaseEntity
{
    public Guid BankUid { get; set; }
    public Bank Bank { get; set; }
    public Guid TestUid { get; set; }
    public Test Test { get; set; }
    public HashSet<Question> Questions { get; set; }
}

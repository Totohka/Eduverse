using Eduverse.Model.Entities.BankTasks;
using Eduverse.Model.Entities.Bases;
using Eduverse.Model.Entities.Users;

namespace Eduverse.Model.Entities.ZeroCode;

public class Test : GridableItem
{
    public BankTest BankTest { get; set; }
    public HashSet<Result> Results { get; set; }
}

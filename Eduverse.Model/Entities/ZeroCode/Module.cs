using Eduverse.Model.Entities.BankTasks;
using Eduverse.Model.Entities.Bases;

namespace Eduverse.Model.Entities.ZeroCode;

public class Module : GridableItem
{
    public HashSet<ModuleRight> ModuleRights { get; set; }
    public BankModule BankModule { get; set; }
}

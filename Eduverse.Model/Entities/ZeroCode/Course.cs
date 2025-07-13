using Eduverse.Model.Entities.BankTasks;
using Eduverse.Model.Entities.Bases;

namespace Eduverse.Model.Entities.ZeroCode;

public class Course : ZeroCodeItem
{
    public string Title { get; set; }
    public string Description { get; set; }
    public HashSet<CourseRight> CourseRights { get; set; }
    public Bank Bank { get; set; }
}

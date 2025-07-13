using Eduverse.Model.Entities.Bases;
using Eduverse.Model.Entities.ZeroCode;

namespace Eduverse.Model.Entities.BankTasks;

public class Bank : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid CourseUid { get; set; }
    public Course Course { get; set; }
}

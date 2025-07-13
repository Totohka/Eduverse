using Eduverse.Model.Entities.Bases;
using Eduverse.Model.Entities.ZeroCode;

namespace Eduverse.Model.Entities.Users;

public class Result : BaseEntity
{
    public Guid UserUid { get; set; }
    public User User { get; set; }
    public Guid TestUid { get; set; }
    public Test Test { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime? DateEnd { get; set; }
    /// <summary>
    /// Всё будет храниться в xml
    /// </summary>
    public string Body { get; set; }
}

using Eduverse.Model.Entities.Bases;
using Eduverse.Model.Entities.ZeroCode;

namespace Eduverse.Model.Entities.Users;

public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? MiddleName { get; set; }
    public string Email { get; set; }
    public bool IsAdmin { get; set; } = false;
    public byte[] Salt { get; set; }
    public string HashPassword { get; set; }
    public Guid? RefreshTokenUid { get; set; }
    public RefreshToken? RefreshToken { get; set; }
    public bool IsActive { get; set; }
    public HashSet<CourseRight> CourseRights { get; set; }
    public HashSet<ModuleRight> ModuleRights { get; set; }
    public HashSet<Structure> Structures { get; set; }
    public HashSet<Result> Results { get; set; }
}

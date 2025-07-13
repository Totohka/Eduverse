using Eduverse.Model.Entities.Bases;
using System.Text;
using System.Text.Unicode;

namespace Eduverse.Model.Entities.Users;

public class RefreshToken : BaseEntity
{
    public byte[] Value { get; set; }
    public DateTime DateStart { get; set; } = DateTime.UtcNow;
    public DateTime? DateExpire { get; set; }
    public DateTime? DateEnd { get; set; }
    public bool IsActive { get; set; }
    public HashSet<RefreshToken> RefreshTokens { get; set; }

    public string GetValue()
    {
        return Encoding.UTF8.GetString(Value);
    }
}

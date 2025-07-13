using Eduverse.Model.Entities.ZeroCode;

namespace Eduverse.Model.Entities.Bases
{
    public class ZeroCodeItem : BaseEntity
    {
        public bool AlienCss { get; set; }
        public string? Css { get; set; }
        public Guid StructureUid { get; set; }
        public Structure Structure { get; set; }
    }
}

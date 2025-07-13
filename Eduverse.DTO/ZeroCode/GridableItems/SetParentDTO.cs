using Eduverse.Model.Entities.Bases;
using Eduverse.Model.Entities.ZeroCode;

namespace Eduverse.DTO.ZeroCode.GridableItems
{
    public class SetParentDTO
    {
        public Guid NewGridUid { get; set; } 
        public Guid CurrentItemUid { get; set; }
        public int GridRowStart { get; set; }
        public int GridRowEnd { get; set; }
        public int GridColumnStart { get; set; }
        public int GridColumnEnd { get; set; }
    }
}

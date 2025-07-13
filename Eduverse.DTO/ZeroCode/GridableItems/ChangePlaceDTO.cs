using Eduverse.Model.Entities.Bases;

namespace Eduverse.DTO.ZeroCode.GridableItems
{
    public class ChangePlaceDTO
    {
        public Guid GridUid { get; set; }
        public Guid CurrentItemUid { get; set; }
        public int GridRowStart { get; set; }
        public int GridRowEnd { get; set; }
        public int GridColumnStart { get; set; }
        public int GridColumnEnd { get; set; }
    }
}

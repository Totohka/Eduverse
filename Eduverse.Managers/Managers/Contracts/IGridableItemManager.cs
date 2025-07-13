using Eduverse.DTO.ZeroCode.GridableItems;
using Eduverse.Model.Entities.Bases;

namespace Eduverse.Managers.Managers.Contracts
{
    public interface IGridableItemManager<T> : IZeroCodeManager<T>
        where T : GridableItem
    {
        public Task SetParentGrid(SetParentDTO dto);
        public Task ChangePlaceInGrid(ChangePlaceDTO dto);
        public Task SetSizeGrid(int countColumn, int countRow);
    }
}

using Eduverse.Model.Entities.Bases;

namespace Eduverse.Managers.Managers.Contracts
{
    public interface IZeroCodeManager<T> : IBaseManager<T>
        where T : ZeroCodeItem
    {
        public Task SetParentStructure(Guid currentItemUid, Guid parentItemUid);
        public Task SetCss(Guid currentItemUid, string css);
        public Task SetDefaultCss(Guid currentItemUid);
    }
}

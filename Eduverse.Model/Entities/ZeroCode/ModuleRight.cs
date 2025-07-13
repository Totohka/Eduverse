using Eduverse.Model.Entities.Bases;
using Eduverse.Model.Entities.Users;

namespace Eduverse.Model.Entities.ZeroCode
{
    public class ModuleRight : BaseEntity
    {
        public Guid UserUid { get; set; }
        public User User { get; set; }
        public Guid ModuleUid { get; set; }
        public Module Module { get; set; }
        public bool IsRead { get; set; }

        /// <summary>
        /// Временный ли доступ?
        /// </summary>
        public bool IsTemporary { get; set; }
        public DateTime DateStartAccess { get; set; }
        public DateTime DateLastUpdate { get; set; }

        /// <summary>
        /// Если доступ временный, то устанавливается крайний срок до окончания доступа
        /// </summary>
        public DateTime? DateExpireAccess { get; set; }
        public bool IsActive { get; set; }
    }
}

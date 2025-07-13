using Eduverse.Model.Entities.Bases;
using Eduverse.Model.Entities.Users;

namespace Eduverse.Model.Entities.ZeroCode;

public class CourseRight : BaseEntity
{
    public Guid UserUid { get; set; }
    public User User { get; set; }
    public Guid CourseUid { get; set; }
    public Course Course { get; set; }

    /// <summary>
    /// Учитывать ли права на чтения на модули
    /// </summary>
    public bool IsRightModule { get; set; }

    /// <summary>
    /// Можно ли читать курс без оплаты
    /// </summary>
    public bool IsRead { get; set; }

    /// <summary>
    /// Можно ли создавать/удалять новые элементы в курсе
    /// </summary>
    public bool IsCreate { get; set; }

    /// <summary>
    /// Можно ли редактировать существующие элементы
    /// </summary>
    public bool IsUpdate { get; set; }

    /// <summary>
    /// Можно ли удалить курс
    /// </summary>
    public bool IsDelete { get; set; }

    /// <summary>
    /// Можно ли установить права на курс другим пользователям
    /// </summary>
    public bool IsSetRight { get; set; }

    /// <summary>
    /// Можно ли забрать права на курс у других пользователей
    /// </summary>
    public bool IsRemoveRight { get; set; }

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

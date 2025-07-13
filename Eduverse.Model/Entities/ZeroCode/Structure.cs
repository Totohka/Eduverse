using Eduverse.Model.Entities.Bases;
using Eduverse.Model.Entities.Users;
using Eduverse.Model.Enums;

namespace Eduverse.Model.Entities.ZeroCode;

public class Structure : BaseEntity
{
    public Guid? ParentStructureUid { get; set; }
    public Structure? ParentStructure { get; set; }
    public StructureTypes StructureTypes { get; set; }
    public Guid AuthorUid { get; set; }
    public User Author { get; set; }

    #region Связи
    public Course? Course { get; set; }
    public Grid? Grid { get; set; }
    public Module? Module { get; set; }
    public Test? Test { get; set; }
    public Text? Text { get; set; }
    public Video? Video { get; set; }
    public File? File { get; set; }
    public Image? Image { get; set; }
    public RadioBox? RadioBox { get; set; }
    public CheckBox? CheckBox { get; set; }
    public TextBox? TextBox { get; set; }
    public AccordanceBox? AccordanceBox { get; set; }
    #endregion
}

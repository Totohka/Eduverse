namespace Eduverse.Model.Entities.Bases
{
    public class GridableItem : ZeroCodeItem
    {
        public int? GridRowStart { get; set; }
        public int? GridRowEnd { get; set; }
        public int? GridColumnStart { get; set; }
        public int? GridColumnEnd { get; set; }
    }
}

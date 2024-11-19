public class EDI
{
    public ISA ISA { get; set; }
    public GS GS { get; set; }
    public List<STSegment> STSegments { get; set; } = new List<STSegment>();
    public SE SE { get; set; }
    public GE GE { get; set; }
    public IEA IEA { get; set; } 
}
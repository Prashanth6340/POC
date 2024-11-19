public class STSegment
{
    public string TransactionSetIdentifierCode { get; set; }
    public string TransactionSetControlNumber { get; set; }
    public SE SE { get; set; } 
    public List<B4> B4Segments { get; set; } = new List<B4>();
    public List<N9> N9Segments { get; set; } = new List<N9>();
    public Q2 Q2 { get; set; }
    public List<SG> SGSements { get; set; } = new List<SG>();
    public List<R4> R4Segments { get; set; } = new List<R4>();
    
}
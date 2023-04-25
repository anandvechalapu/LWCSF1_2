namespace SacralNewspreadnetcode 
{
    public class PriceChanges
    {
        public int Id { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public DateTime DateChanged { get; set; }
    }
}
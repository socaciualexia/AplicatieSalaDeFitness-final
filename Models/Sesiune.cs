public class Sesiune
{
    public int SesiuneId { get; set; }
    public string Tip { get; set; }
    public int AntrenorId { get; set; }
    public Antrenor? Antrenor { get; set; }
    public DateTime Data { get; set; }
}

public class Feedback
{
    public int FeedbackId { get; set; }
    public string Text { get; set; }
    public int AntrenorId { get; set; }
    public Antrenor? Antrenor { get; set; }
}

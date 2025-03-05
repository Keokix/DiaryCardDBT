namespace MyDBT.Model;

public class ActivityModel
{
    public string ActivityName { get; set; }
    public string DurationUsed { get; set; }
    public List<(int, string)> Usefulness { get; set; }
    public string Time { get; set; }
}
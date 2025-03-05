namespace MyDBT.Model;

public class SportModel
{
    public string SportName { get; set; }
    public string DurationUsed { get; set; }
    public List<(int, string)> Usefulness { get; set; }
    public List<(int, string)> Intensity { get; set; }
    public string Time { get; set; }
}
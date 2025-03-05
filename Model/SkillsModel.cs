namespace MyDBT.Model;

public class SkillsModel
{
    public string SkillName { get; set; }
    public string DurationUsed { get; set; }
    public List<(int, string)> Usefulness { get; set; }
    public string Time { get; set; }
}
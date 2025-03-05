namespace MyDBT.Model;

public class ProblemBehaviorModel
{
    public string ProblemName { get; set; }
    public string ProblemDescription { get; set; }
    public List<(int, string)> Urge { get; set; }
    public bool GivenIn { get; set; }
    public string Notes { get; set; }

}
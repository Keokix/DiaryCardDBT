namespace MyDBT.Model;

public class SuperiorGoalModel
{
    public string GoalName { get; set; }
    public string GoalDescription { get; set; }
    public List<(int, string)> GoalTriedAmount { get; set; }
    public bool WasInMind { get; set; }
    public string Notes { get; set; }
}
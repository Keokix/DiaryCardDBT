namespace MyDBT.Model;

public class InterpersonalSkillsModel
{
    public List<(int, string)> GoalFocus { get; set; }
    public List<(int, string)> RelationshipFocus { get; set; }
    public List<(int, string)> SelfRespectFocus { get; set; }
    public List<(int, string)> SayingNo { get; set; }
    public List<(int, string)> AskingForHelp { get; set; }
    public List<(int, string)> RemoveObstacles { get; set; }
    public List<(int, string)> Validate { get; set; }
}
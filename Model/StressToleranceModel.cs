namespace MyDBT.Model;

public class StressToleranceModel
{
    public List<(int, string)> Distracting { get; set; }
    public List<(int, string)> BodySensation { get; set; }
    public List<(int, string)> ChangeMoment { get; set; }
    public List<(int, string)> ProContra { get; set; }
    public List<(int, string)> DirectedAttention { get; set; }
    public List<(int, string)> NewWayDecision { get; set; }
    public List<(int, string)> InnerWillingness { get; set; }
    public List<(int, string)> SmallSmiling { get; set; }
    public List<(int, string)> RadicalAcceptance { get; set; }
    public List<(int, string)> AttentionExercise { get; set; }
}
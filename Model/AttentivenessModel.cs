namespace MyDBT.Model;

public class AttentivenessModel
{
    public List<(int, string)> Perceived { get; set; }
    public List<(int, string)> Describing { get; set; }
    public List<(int, string)> Participate { get; set; }
    public List<(int, string)> Assuming { get; set; }
    public List<(int, string)> Concentrated { get; set; }
    public List<(int, string)> Effectiveness { get; set; }
    public List<(int, string)> WiseMind { get; set; }
    public List<(int, string)> BreathingExercises { get; set; }

}
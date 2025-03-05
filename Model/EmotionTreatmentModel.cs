namespace MyDBT.Model;

public class EmotionTreatmentModel
{
    public List<(int, string)> DangerTrap { get; set; }
    public List<(int, string)> EverydayHero { get; set; }
    public List<(int, string)> VeinAha { get; set; }
    public List<(int, string)> OppositeDirectionActing { get; set; }
    public List<(int, string)> FactChecking { get; set; }
    public List<(int, string)> HealthyAbc { get; set; }
    public List<(int, string)> EmotionSurfing { get; set; }
    public List<(int, string)> RelativizeDogmas { get; set; }
    public List<(int, string)> ThinkingStop { get; set; }
}
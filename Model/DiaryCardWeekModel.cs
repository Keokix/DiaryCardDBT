namespace MyDBT.Model;

public class DiaryCardWeekModel
{
    public List<DiaryCardDayModel>? Week { get; set; }
    public string BestWeekEvent { get; set; }
    public string WorstWeekEvent { get; set; }
    public string WeeklyGoal { get; set; }

}
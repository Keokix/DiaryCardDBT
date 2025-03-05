namespace MyDBT.Model;

public class DiaryCardDayModel
{
    public List<SelfharmModel>? SelfHarm { get; set; }
    public List<DrugsModel>? Drugs { get; set; }
    public List<SkillsModel>? Skills { get; set; }
    public List<MedicationModel>? Medication { get; set; }
    public List<ProblemBehaviorModel>? ProblemBehaviors { get; set; }
    public List<SuperiorGoalModel>? SuperiorGoals { get; set; }
    public List<EmotionsModel>? Emotions { get; set; }
    public List<SportModel>? Sport { get; set; }
    public List<ActivityModel>? Activities { get; set; }
    public List<AttentivenessModel>? Attentiveness { get; set; }
    public List<EmotionTreatmentModel>? EmotionTreatment { get; set; }
    public List<StressToleranceModel>? StressTolerance { get; set; }
    public List<InterpersonalSkillsModel>? InterpersonalSkills { get; set; }
    public List<SelfEsteemModel>? SelfEsteem { get; set; }
    public List<(int, string)> SleepQuality { get; set; }
    public List<(int, string)> Dissociate { get; set; }
    public List<(int, string)> TrustInTherapy { get; set; }
    public List<(int, string)> SuicideThoughts { get; set; }
    public List<(int, string)> HoursSlept { get; set; }
    public List<(string, bool)> HomeWork { get; set; }
    public List<string>? PatientNotes { get; set; }
    public string? GoodEvent { get; set; }
    public string? BadEvent { get; set; }
    public string? TherapistNotes { get; set; }
    public string? GeneralNotes { get; set; }
    public string? Date { get; set; }
    public string? DayOfTheWeek { get; set; }
    public string? WakeUpTime { get; set; }
    public string? SleepingTime { get; set; }
}
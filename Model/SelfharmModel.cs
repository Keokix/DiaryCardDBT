namespace MyDBT.Model;

public class SelfharmModel
{
    public string SelfharmType { get; set; }
    public List<(int, string)> Intensity { get; set; }
    public string Time { get; set; }

}
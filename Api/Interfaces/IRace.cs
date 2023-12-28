namespace Formel1Api.Interfaces;

public interface IRace
{
    public int Id { get; set; }
    public string? WinnerName { get; set; }
    public double WinnerTime { get; set; }
    public string? GrandPrix { get; set; }
    public int NumberOfLaps { get; set; }
    public string? DriverImg { get; set; }
    public string? GrandPrixImg { get; set; }
}
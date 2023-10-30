namespace MediaTracklist.Models;

public class Tracklist
{
    public int Id { get; set;}
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public ICollection<Medium> Media { get; set; }
}
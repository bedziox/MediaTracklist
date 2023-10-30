namespace MediaTracklist.Models;

public class Medium
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Descripiton { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string? ImgUrl { get; set; } = string.Empty;
    public Category Category { get; set;}
}
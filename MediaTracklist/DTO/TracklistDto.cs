namespace MediaTracklist.DTO;

public class TracklistDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public ICollection<MediumDto> Media { get; set; }
    public int UserId { get; set; }
    public UserDto User { get; set; }
}
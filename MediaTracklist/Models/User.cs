namespace MediaTracklist.Models;

public class User
{
    public int Id { get; set;}
    public String Username { get; set; } = String.Empty;
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public String Email { get; set; } = String.Empty;
    public ICollection<Tracklist> Tracklists = null;
}
namespace MediaTracklist.Models;

public class User
{
    public int Id { get; set;}
    public String Username { get; set; } = String.Empty;
    private String _password { get; set; } =  String.Empty;
    private String _email { get; set; } = String.Empty;
    public ICollection<Tracklist> Tracklists = null;
}
namespace YouPipe.Models;

public class Video
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool? IsStreamAvalible { get; set; }
    public bool? IsListed { get; set; }
}
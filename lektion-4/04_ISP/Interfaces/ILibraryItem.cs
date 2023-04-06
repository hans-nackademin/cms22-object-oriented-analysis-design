namespace _04_ISP.Interfaces;

public interface ILibraryItem
{
    string ISBN { get; set; }
    string Title { get; set; }
    string Language { get; set; }
    string BookPublisher { get; set; }
    List<string> Authors { get; set; }
    List<string> Translators { get; set; }
    DateTime ReleaseDate { get; set; }
    string Edition { get; set; }
    string Serie { get; set; }
}

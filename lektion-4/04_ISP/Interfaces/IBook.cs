namespace _04_ISP.Interfaces;

public interface IBook : ILibraryItem
{
    int Pages { get; set; }

    List<string> Illustrators { get; set; }
}

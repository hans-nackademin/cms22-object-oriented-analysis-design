namespace _04_ISP.Interfaces
{
    public interface IAudioBook : ILibraryItem, IBorrowable
    {
        string PlayTime { get; set; }
        List<string> AvailableFormats { get; set; }
        List<string> Readers { get; set; }
    }
}

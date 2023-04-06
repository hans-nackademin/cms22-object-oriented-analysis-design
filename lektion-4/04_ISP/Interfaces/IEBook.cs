namespace _04_ISP.Interfaces;

public interface IEBook : IBook, IBorrowable
{
    List<string> AvailableFormats { get; set; }
}

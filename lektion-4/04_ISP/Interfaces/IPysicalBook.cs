namespace _04_ISP.Interfaces
{
    public interface IPhysicalBook : IBook
    {
        decimal Weight { get; set; }
    }
}

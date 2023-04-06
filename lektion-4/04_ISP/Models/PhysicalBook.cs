using _04_ISP.Interfaces;

namespace _04_ISP.Models;

public class PhysicalBook : Book, IPhysicalBook
{
    public decimal Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}

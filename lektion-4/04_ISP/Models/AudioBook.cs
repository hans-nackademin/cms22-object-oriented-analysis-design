using _04_ISP.Interfaces;

namespace _04_ISP.Models
{
    public class AudioBook : Book, IAudioBook
    {
        public string PlayTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> AvailableFormats { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> Readers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Borrowable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

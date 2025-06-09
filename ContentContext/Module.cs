using _2802_Course.SharedContext;

namespace _2802_Course.ContentContext;

public class Module : Base
{
    public Module()
    {
        Lectures = new List<Lecture>();
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public IList<Lecture> Lectures { get; set; }
}
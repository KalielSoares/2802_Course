using _2802_Course.ContentContext.Enums;
using _2802_Course.SharedContext;

namespace _2802_Course.ContentContext;

public class Lecture : Base
{
    public int Ordem { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
}
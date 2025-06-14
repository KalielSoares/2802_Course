using _2802_Course.SharedContext;

namespace _2802_Course.ContentContext;

public class CareerItem : Base
{
    public CareerItem(
        int order,
        string title,
        string description,
        Course course)
    {
        
            

        Order = order;
        Title = title;
        Description = description;
        Course = course;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
}
using _2802_Course.NotificationContext;

namespace _2802_Course.SharedContext;

public abstract class Base : Notifiable
{
    public Base()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}
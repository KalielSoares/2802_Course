using _2802_Course.SharedContext;

namespace _2802_Course.SubscriptionContext;

public class Student : Base
{
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    
}
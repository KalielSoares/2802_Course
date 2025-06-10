using _2802_Course.SharedContext;

namespace _2802_Course.SubscriptionContext;

public class Plan : Base
{
    public string Title { get; set; }
    public decimal Price { get; set; }
}
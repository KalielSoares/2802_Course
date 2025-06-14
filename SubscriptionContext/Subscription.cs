using _2802_Course.SharedContext;

namespace _2802_Course.SubscriptionContext;

public class Subscription : Base
{
    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }

    public bool IsInactive => EndDate <= DateTime.Now;
}
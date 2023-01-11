namespace DesignPatterns.Observer.Example
{
    internal class Publisher
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update();
            }
        }
    }
}

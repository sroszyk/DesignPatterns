namespace DesignPatterns.Observer.Example.OneFile
{
    #region SUBSCRIBERS

    //SUBSCRIBERS

    internal interface ISubscriber
    {
        void Update();
    }

    internal class SubscriberA : ISubscriber
    {
        public void Update()
        {
            Console.WriteLine("Hello! I am SubscriberA");
        }
    }

    internal class SubscriberB : ISubscriber
    {
        public void Update()
        {
            Console.WriteLine("Hello! I am SubscriberB");
        }
    }

    #endregion

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

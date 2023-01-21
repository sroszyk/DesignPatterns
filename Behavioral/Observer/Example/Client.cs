namespace DesignPatterns.Observer.Example
{
    internal class Client
    {
        public void Main()
        {
            Publisher publisher = new Publisher();

            SubscriberA subscriberA = new SubscriberA();
            SubscriberB subscriberB = new SubscriberB();

            publisher.Subscribe(subscriberA);
            publisher.Subscribe(subscriberB);

            publisher.NotifySubscribers();
        }
    }
}

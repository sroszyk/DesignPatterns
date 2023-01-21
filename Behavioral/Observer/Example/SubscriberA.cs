namespace DesignPatterns.Observer.Example
{
    internal class SubscriberA : ISubscriber
    {
        public void Update()
        {
            Console.WriteLine("Hello! I am SubscriberA");
        }
    }
}

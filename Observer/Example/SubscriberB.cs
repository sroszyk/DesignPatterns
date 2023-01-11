namespace DesignPatterns.Observer.Example
{
    internal class SubscriberB : ISubscriber
    {
        public void Update()
        {
            Console.WriteLine("Hello! I am SubscriberB");
        }
    }
}

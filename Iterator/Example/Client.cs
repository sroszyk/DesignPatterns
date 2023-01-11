namespace DesignPatterns.Iterator.Example
{
    internal class Client
    {
        public void Main()
        {
            IIterableCollection collection = new IterableCollection();

            var iterator = collection.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetNext());
            }
        }
    }
}

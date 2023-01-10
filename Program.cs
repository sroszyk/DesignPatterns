using DesignPatterns.Iterator.Example;

IIterableCollection collection = new IterableCollection();

var iterator = collection.GetIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.GetNext());
}
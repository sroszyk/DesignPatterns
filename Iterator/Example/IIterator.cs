namespace DesignPatterns.Iterator.Example
{
    internal interface IIterator
    {
        int GetNext();

        bool HasNext();
    }
}

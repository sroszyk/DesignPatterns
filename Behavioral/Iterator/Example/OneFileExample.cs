namespace DesignPatterns.Iterator.Example.OneFile
{
    #region COLLECTION

    //COLLECTION

    internal interface IIterableCollection
    {
        IIterator GetIterator();
    }

    internal class IterableCollection : IIterableCollection
    {
        private readonly int[] collection = new int[] { 1, 2, 3, 4, 5 };
        public IIterator GetIterator()
        {
            return new Iterator(this);
        }

        public int GetValue(int idx)
        {
            if (idx > collection.Length - 1)
            {
                return -1;
            }

            return collection[idx];
        }
    }

    #endregion

    #region ITERATOR

    //ITERATOR

    internal interface IIterator
    {
        int GetNext();

        bool HasNext();
    }

    internal class Iterator : IIterator
    {
        private readonly IterableCollection collection;
        private int state = 0;

        public Iterator(IterableCollection collection)
        {
            this.collection = collection;
        }

        public int GetNext()
        {
            var result = collection.GetValue(state);

            state++;

            return result;
        }

        public bool HasNext()
        {
            return collection.GetValue(state + 1) != -1;
        }
    }

    #endregion ITERATOR
}

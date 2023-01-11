namespace DesignPatterns.Memento.Example
{
    internal class Caretaker
    {
        private readonly Originator originator;
        private readonly List<Originator.Memento> history = new List<Originator.Memento>();

        public Caretaker(Originator originator)
        {
            this.originator = originator;
        }

        public void DoSomething(string data)
        {
            originator.Operation(data);
            history.Add(originator.Save());
        }

        public void Undo()
        {
            var historyToRestore = history.Last();

            history.Remove(historyToRestore);

            originator.Restore(historyToRestore);
        }
    }
}

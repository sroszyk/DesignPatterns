namespace DesignPatterns.Memento.Example.OneFile
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

    internal class Originator
    {
        public class Memento
        {
            private readonly string state;

            public Memento(string state)
            {
                this.state = state;
            }

            public string GetState()
            {
                return this.state;
            }
        }

        private string state;

        public Memento Save()
        {
            return new Memento(state);
        }

        public void Restore(Memento memento)
        {
            state = memento.GetState();
        }

        public void Operation(string data)
        {
            state = data;
        }

        public void DisplayState()
        {
            Console.WriteLine(state);
        }
    }
}

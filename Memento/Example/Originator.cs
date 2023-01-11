namespace DesignPatterns.Memento.Example
{
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

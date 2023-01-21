namespace DesignPatterns.Memento.Example
{
    internal class Client
    {
        public void Main()
        {
            Originator originator = new Originator();

            Caretaker caretaker = new Caretaker(originator);

            caretaker.DoSomething("Operation1");
            caretaker.DoSomething("Operation2");
            caretaker.DoSomething("Operation3");
            caretaker.DoSomething("Operation4");

            originator.DisplayState();

            caretaker.Undo();
            caretaker.Undo();
            caretaker.Undo();

            originator.DisplayState();
        }
    }
}

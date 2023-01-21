namespace DesignPatterns.ChainOfResponsibility.Example
{
    internal class Client
    {
        public void Main()
        {
            var handler1 = new Handler1();
            var handler2 = new Handler2();
            var handler3 = new Handler3();

            handler1.SetNext(handler2);
            handler2.SetNext(handler3);

            handler1.Handle("Request");
        }
    }
}

namespace DesignPatterns.ChainOfResponsibility.Example
{
    internal interface IHandler
    {
        void SetNext(IHandler handler);

        void Handle(string request);
    }
}

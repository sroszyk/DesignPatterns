namespace DesignPatterns.ChainOfResponsibility
{
    internal interface IHandler
    {
        void SetNext(IHandler handler);

        void Handle(string request);
    }
}

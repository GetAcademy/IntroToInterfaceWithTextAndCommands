namespace Todo
{
    internal interface ICommand
    {
        void Run();
        string Name { get; }
        string MenuText { get; }
    }
}

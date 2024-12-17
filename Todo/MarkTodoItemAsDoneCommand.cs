namespace Todo
{
    internal class MarkTodoItemAsDoneCommand : ICommand
    {
        private readonly TodoList _todoList;
        public string Name { get; }
        public string MenuText { get; }

        public MarkTodoItemAsDoneCommand(TodoList todoList)
        {
            _todoList = todoList;
            Name = "3";
            MenuText = "Marker som gjort";
        }

        public void Run()
        {
            Console.Write("Hvilket nr vil du sette som utført? ");
            var noStr = Console.ReadLine();
            var no = Convert.ToInt32(noStr);
            var index = no - 1;
            _todoList.MarkAsDone(index);
        }

    }
}

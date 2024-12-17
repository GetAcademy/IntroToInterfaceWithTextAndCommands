namespace Todo
{
    internal class DeleteTodoItemCommand : ICommand
    {
        private readonly TodoList _todoList;
        public string Name { get; }
        public string MenuText { get; }

        public DeleteTodoItemCommand(TodoList todoList)
        {
            _todoList = todoList;
            Name = "2";
            MenuText = "Slett";
        }

        public void Run()
        {
            Console.Write("Hvilket nr vil du slette? ");
            var noStr = Console.ReadLine();
            var no = Convert.ToInt32(noStr);
            var index = no - 1;
            _todoList.Delete(index);
        }
    }
}

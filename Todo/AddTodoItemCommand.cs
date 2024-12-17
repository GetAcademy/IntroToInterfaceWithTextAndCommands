namespace Todo
{
    internal class AddTodoItemCommand : ICommand
    {
        private readonly TodoList _todoList;
        public string Name { get; }
        public string MenuText { get; }

        public AddTodoItemCommand(TodoList todoList)
        {
            _todoList = todoList;
            Name = "1";
            MenuText = "Legg til";
        }

        public void Run()
        {
            Console.WriteLine("Legg til");
            Console.Write("Hvor mange dager til fristen? ");
            var daysToDeadlineStr = Console.ReadLine();
            var daysToDeadLine = Convert.ToInt32(daysToDeadlineStr);
            Console.Write("Hva skal gjøres? ");
            var text = Console.ReadLine();
            var todoItem = new TodoItem(text, daysToDeadLine);
            _todoList.Add(todoItem);
        }
    }
}

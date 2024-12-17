namespace TextElements.SimpleElements
{
    internal class BulletPoint : ITextElement
    {
        private string _text;

        public BulletPoint(string text)
        {
            _text = text;
        }

        public void Show()
        {
            Console.Write(" * ");
            Console.WriteLine(_text);
        }
    }
}

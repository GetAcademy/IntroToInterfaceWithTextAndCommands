namespace Stars
{
    internal class BlinkingStar : IStar
    {
        private int _col;
        private int _row;
        private int _phase;

        public BlinkingStar(int col, int row)
        {
            _row = row;
            _col = col;
        }

        public void Show()
        {
            Console.SetCursorPosition(_col, _row);
            var c = _phase == 0 ? '*' : ' ';
            Console.Write(c);
        }

        public void Update()
        {
            _phase = _phase == 0 ? 1 : 0;
            Terje();
        }

        public void Terje()
        {

        }
    }
}

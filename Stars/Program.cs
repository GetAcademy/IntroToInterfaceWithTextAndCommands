using Stars;

var star1 = new BlinkingStar(5, 5);
var star2 = new MovingStar(1, 10);

var stars = new IStar[] { star1, star2 };

while (true)
{
    Console.Clear();
    foreach (IStar star in stars)
    {
        star.Update();
        star.Show();
    }
    Console.SetCursorPosition(1, 20);
    Thread.Sleep(300);
}
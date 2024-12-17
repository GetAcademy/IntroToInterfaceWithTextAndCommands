// See https://aka.ms/new-console-template for more information

using TextElements.SimpleElements;

Console.WriteLine("Hello, World!");

var centeredHeader = new CenteredHeader("Hei", '*');
var bulletPointA = new BulletPoint("a");
var bulletPointB = new BulletPoint("b");
var bulletPointC = new BulletPoint("c");
var text = string.Concat(Enumerable.Repeat("Det var en gang.", 22));
var indentedParagraph = new IndentedParagraph(text);
bulletPointA.Show();
bulletPointB.Show();
bulletPointC.Show();
var invertedText = new InvertedText("Terje");

centeredHeader.Show();
indentedParagraph.Show();
bulletPointA.Show();
bulletPointB.Show();
bulletPointC.Show();
invertedText.Show();

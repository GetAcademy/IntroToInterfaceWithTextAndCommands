using TextElements.SimpleElements;

var centeredHeader = new CenteredHeader("Hei", '*');
var bulletPointA = new BulletPoint("a");
var bulletPointB = new BulletPoint("b");
var bulletPointC = new BulletPoint("c");
var text = string.Concat(Enumerable.Repeat("Det var en gang.", 22));
var indentedParagraph = new IndentedParagraph(text);
var invertedText = new InvertedText("Terje");

var textElements = new ITextElement[]
{
    centeredHeader, bulletPointA, bulletPointB, bulletPointC, indentedParagraph, invertedText
};

foreach (ITextElement textElement in textElements)
{
    textElement.Show();
}

/*
v1 - uten interface

foreach (var textElement in textElements)
{
    if (textElement is CenteredHeader)
    {
        var element = (CenteredHeader)textElement;
        element.Show();
    }
    else if (textElement is BulletPoint)
    {
        var element = (BulletPoint)textElement;
        element.Show();
    }
}
*/

/*
Utgangspunkt

   var centeredHeader = new CenteredHeader("Hei", '*');
   var bulletPointA = new BulletPoint("a");
   var bulletPointB = new BulletPoint("b");
   var bulletPointC = new BulletPoint("c");
   var text = string.Concat(Enumerable.Repeat("Det var en gang.", 22));
   var indentedParagraph = new IndentedParagraph(text);
   var invertedText = new InvertedText("Terje");
   
   
   bulletPointA.Show();
   bulletPointB.Show();
   bulletPointC.Show();
   centeredHeader.Show();
   indentedParagraph.Show();
   bulletPointA.Show();
   bulletPointB.Show();
   bulletPointC.Show();
   invertedText.Show();
   
 */
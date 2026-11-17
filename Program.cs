#region Q1
using System.Text;

string Title = " clean code ";
 String Title01 = Title.ToUpper();
Console.WriteLine(Title);
Console.WriteLine(Title01);
#endregion

#region Q2
string x = "Clean Code";
string y = "Clean Code";
Console.WriteLine(Object.ReferenceEquals(x,y));

#endregion

#region Q3
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Book List");
Console.WriteLine(stringBuilder.ToString());
stringBuilder.Append("-updated");
Console.WriteLine(stringBuilder.ToString());
#endregion

#region Q4
stringBuilder.Replace("Book List","Library");
Console.WriteLine(stringBuilder.ToString());
#endregion

#region Q5
string title = "Clean Code";
int pages = 464;
Console.WriteLine("Book: " + title + ", Pages: " + pages);
#endregion

#region Q6
string sentence2 = $"Book: {title}, Pages: {pages}";
Console.WriteLine(sentence2);
#endregion

#region Q7
string sentence3 = string.Format("Book: {0}, Pages: {1}", title, pages);
Console.WriteLine(sentence3);
#endregion

#region Q8
int pages01 = 464;
if(pages01 > 300)
{
    Console.WriteLine("Long Book.");
}
else
{
    Console.WriteLine("Short Book.");
}
#endregion

#region Q9
int pages09 = 464;
bool isAvailable = true;
if(pages09 > 300 && isAvailable==true)
{
    Console.WriteLine("You can borrow this book");
}
else
{
    Console.WriteLine("You cannot borrow this book.");
}
#endregion

#region Q10
string title10 = "Refactoring";
switch (title10)
{
    case "Refactoring":
        Console.WriteLine("Nice book!");
        break;
        case "Clean Code": 
            Console.WriteLine("Great choice");
            break;
        default:
        Console.WriteLine("Never heard");
        break;
}
#endregion

#region Q11
int pages11 = 464;
if(pages11 > 300)
{
    Console.WriteLine("Long Book.");

}
else
{
    Console.WriteLine("Short Book.");
}
#endregion

#region Q12
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
for(int i = 0; i < books.Length; i++)
{
    Console.WriteLine(books[i]);
}
#endregion

#region Q13
int index = 0;
while (index < books.Length)
{
    Console.WriteLine(books[index]);
    index++;
}
#endregion

#region Q14
int count = 0;
do
{
    Console.WriteLine("Checking book...");
    count++;
} while (count < books.Length);
#endregion

#region Q15
foreach (string book in books)
{
    Console.WriteLine(book);
}
#endregion

#region Q16
foreach (string book in books)
{
    if(book == "Refactoring")
    {
        break;
    }
    Console.WriteLine(book);
}
#endregion

#region Q17
foreach (string book in books)
{
    if (book == "The Pragmatic Programmer")
    {
        continue;
    }
    Console.WriteLine(book);
}
#endregion

static void PrintFirstBook(string[] books)
{
    if (books.Length == 0)
    {
        return;
    }

    Console.WriteLine(books[0]);
}
PrintFirstBook(books);

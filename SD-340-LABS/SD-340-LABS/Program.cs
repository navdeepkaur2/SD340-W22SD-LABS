using System.Text;

string ConcatinateString(string wordArg, int numArg, string s)
{
    string string1 = s;
    for(int i = 1; i < numArg; i++)
    {
        s += string1;
    }
    return string1;
}


string myString = "go away";
int myInt = 4;

myDelegate newDelegate = new myDelegate(ConcatinateString);

Console.WriteLine(newDelegate(myString,myInt));
delegate string myDelegate  (string wordArg, int numArg);
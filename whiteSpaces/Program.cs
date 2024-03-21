/*
The following code converts the given string into a char array and reserve it.
Then it counts the 'o' in the array and converts it back into an string and print it.
*/


string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage)
{
    if (i == '0')
        {
            x++;
        }
}

string new_message = new string(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
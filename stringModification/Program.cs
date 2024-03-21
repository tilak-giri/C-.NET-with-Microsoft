const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

int starterPoint = input.IndexOf("<span>");
starterPoint +=6;
int endPoint = input.IndexOf("</span>");
int length = endPoint - starterPoint;
quantity = input.Substring(starterPoint, length);

output = input;
output = output.Replace("<div>", "");
output = output.Replace("</div>", "");
output = output.Replace("&trade", "&reg");



Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
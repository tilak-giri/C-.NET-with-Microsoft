// Array declaration
// string[] newString = new string[3];

// accessing elements of array
// newString[0] = "one";
// newString[1] = "two";
// newString[2] = "three";
// newString[3] = "four";

// string[] newString = {"valueone", "valuetwo", "valuethree"};


// // printing the values of array 
// Console.WriteLine($"First: {newString[0]}");
// Console.WriteLine($"Second: {newString[1]}");
// Console.WriteLine($"Third: {newString[2]}");


// newString[0] = "newTestValue";
// Console.WriteLine($"New value: {newString[0]}");

// Console.WriteLine($"The number of elements availabel in the array at the moment are: {newString.Length}");


// string[] names = {"Ram", "Hari", "Laxman"};
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }


// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin=0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");



// Exercise/project of the chapter

string[] orderID={"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
foreach (string fraudID in orderID)
{
    if (fraudID.StartsWith("B"))
    {
        Console.WriteLine(fraudID);
    }
}
﻿/*
the following code creates five random OrderIDs to test the fraud
detection process. OrderIDs consist of a letter from A to E, and a three
digit number. EX. A123
*/
Random random = new Random();
string[] orderIDs = new string[5];
//loop through each blank orderID
for (int i = 0; i<orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
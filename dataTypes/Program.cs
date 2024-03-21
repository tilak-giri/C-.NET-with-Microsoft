string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";


string[] orderID = orderStream.Split(",");

foreach (string order in orderID)
{
    if(order.Length == 4)
    {
        Console.WriteLine(order);
    }else{
        Console.WriteLine($"{order}\t- Error");
    }
}

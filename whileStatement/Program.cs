// Console.WriteLine("Enter a value between 5 to 10.");
// string? readResult;
// bool validNumber = false;
// int numericValue = 0;

// while(validNumber == false){
//     readResult = Console.ReadLine();
//     validNumber = int.TryParse(readResult, out numericValue);
//     if(validNumber==false){
//         Console.WriteLine("Sorry you entered a invalid number, please try again.");
//     }
//     else if(numericValue<5 || numericValue>10){
//         Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
//         validNumber = false;
//     }
// };

// Console.WriteLine($"Your input value ({numericValue}) has been accepted.");











// Console.WriteLine("Enter your role name (Administrator, Manager or User)");
// bool validInput = false;
// string userInput = "";
// string roleInput= "";

// while(validInput == false){
//     userInput = Console.ReadLine();
//     roleInput = userInput.Trim().ToLower();
    
//     if(roleInput == "administrator" || roleInput == "manager" || roleInput == "user"){
//         validInput = true;
//     }
//     else {
//         Console.WriteLine($"The role you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager or User.)");
//         validInput = false;
//     }
// };
// Console.WriteLine($"Your input value ({userInput}) has been accepted.");







string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

foreach(string myString in myStrings){
    periodLocation = myString.IndexOf(".");
    while(periodLocation > 0){
        myString.Substring(0, periodLocation).Remove(".").TrimStart();
        Console.WriteLine(myString);
    }
};
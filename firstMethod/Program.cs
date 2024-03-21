string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string internalDomain = "contosso.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    emailGenerator(corporate, internalDomain);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    emailGenerator(external, externalDomain);
}




void emailGenerator (string[,] names , string domain)
{
    
    for (int i =0; i < names.GetLength(0); i++)
    {
        string emailAddress= "";
        string name = names[i, 0];
        emailAddress = name.Substring(0, 2);
        emailAddress += names[i, 1];
        emailAddress += "@" + domain;
        emailAddress = emailAddress.ToLower();
        Console.WriteLine(emailAddress);
    }
}
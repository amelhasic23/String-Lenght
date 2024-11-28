using System;

class Program
{
    static void Main()
    {
        string firstName = "Peter";
        string lastName = "Jackson";
        string birthDate = "01/01/1980";

        string userInfo = $"First name: {firstName}, Last name: {lastName}, Birth date: {birthDate}";
        Console.WriteLine(userInfo);
    }
}

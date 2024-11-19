using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects;

public class Investment
{
    public string Name { get; set; }
    public string Owner { get; set; }
    public string CurrentStatus { get; set; }
    public string WellKnown { get; set; }
    public string Top10In5Years { get; set; }
    public string OpenedData { get; set; }
    public string ComplaintHistory { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string ResultOfThreeYears { get; set; }

    public void DisplayOfGames()
    {
        string result = $" Name: {Name}\n Owner: {Owner}\n " +
            $"Current status: {CurrentStatus}\n WellKnown: {WellKnown}\n " +
            $"Top 10 in 5 years: {Top10In5Years}\n Opened data: {OpenedData}\n Complaint history: {ComplaintHistory}\n " +
            $"Address: {Address}\n Phone number: {PhoneNumber}\n Result of three years: {ResultOfThreeYears}\n";

        Console.WriteLine(result);
    }


    public static void TurnBackFAANG(string company)
    {
        var result = company;
        result = result.ToUpper();

        if (result == "APPLE" || result == "FACEBOOK" || result == "AMAZON"
            || result == "NETFLIX" || result == "GOOGLE" || result == "MICROSOFT")
        {
            Console.WriteLine("\n\n\t\tThat's FAANG company!!!");
        }
        else
        {
            Console.WriteLine("That's NOT WELL KNOWN company!");
        }
    }

}

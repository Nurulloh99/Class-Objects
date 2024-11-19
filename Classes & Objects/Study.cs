using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes___Objects;

public class Study
{

    public string Directions { get; set; } // C#
    public string WhyChoosen { get; set; } // Oftolmology
    public string DiscoveredTime { get; set; }
    public string Owner { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string YearsOfStudy { get; set; }
    public string OnlineOffline { get; set; }
    public string TuitionFee { get; set; }
    public string Reputation { get; set; }


    public void DisplayInfoStudy()
    {
        string result = $"Directions: {Directions}\n WhyChoosen: {WhyChoosen}\n " +
            $"DiscoveredTime: {DiscoveredTime}\n Owner: {Owner}\n " +
            $"Address: {Address}\n PhoneNumber: {PhoneNumber} YearsOfStudy: {YearsOfStudy} " +
            $"OnlineOffline: {OnlineOffline} TuitionFee: {TuitionFee} Reputation: {Reputation}";
        Console.WriteLine(result);
    }

}

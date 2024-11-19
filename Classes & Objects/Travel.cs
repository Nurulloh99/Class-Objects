using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects;

public class Travel
{
    public string Where { get; set; }
    public string Why { get; set; }
    public string TripItems { get; set; }
    public string TourCompany { get; set; }
    public string PhoneNumber { get; set; }
    public string Hotel { get; set; }
    public string StarsOfHotel { get; set; }
    public string Meals { get; set; }
    public string MainPartners { get; set; }
    public string Security { get; set; }


    public void DisplayInfoTravel()
    {
        string result = $"Where: {Where}\n Why: {Why}\n " +
            $"TripItems: {TripItems}\n TourCompany: {TourCompany}\n " +
            $"PhoneNumber: {PhoneNumber}\n Hotel: {Hotel} StarsOfHotel: {StarsOfHotel} " +
            $"Meals: {Meals} MainPartners: {MainPartners} Security: {Security}";
        Console.WriteLine(result);
    }

}

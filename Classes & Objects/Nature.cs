using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes___Objects;

public class Nature
{
    public string AirPollution { get; set; }
    public string BeautifulPlaces { get; set; }
    public string TouristicPlaces { get; set; }
    public string Forest { get; set; }
    public string NaturalGrassPlants { get; set; }
    public string Living { get; set; }
    public string Construction { get; set; }
    public string BenefitsForPeaople { get; set; }
    public string ContemporaryPlaces { get; set; }
    public string Weather { get; set; }


    public void DisplayOfGames()
    {
        string result = $" Air pollution: {AirPollution}\n Beautiful places: {BeautifulPlaces}\n " +
            $"Touristic places: {TouristicPlaces}\n Forest: {Forest}\n " +
            $"Natural grass plants: {NaturalGrassPlants}\n Living: {Living}\n Construction: {Construction}\n " +
            $"Benefits for peaople: {BenefitsForPeaople}\n Contemporary places: {ContemporaryPlaces}\n Weather: {Weather}\n";

        Console.WriteLine(result);
    }
    

}

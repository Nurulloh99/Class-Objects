using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects;

public class Beauty
{
    public string Place { get; set; } 
    public string Appearence { get; set; } 
    public string Construction { get; set; } 
    public string DiscoveredTime { get; set; }
    public string Culture { get; set; }
    public string WellKnowen { get; set; }
    public string Benefits { get; set; } 
    public string Healthy { get; set; }
    public string Population { get; set; }
    public string Animals { get; set; }

    public void DisplayOfBeauty()
    {
        string result = $" Beautiful place: {Place}\n Appearance: {Appearence}\n " +
            $"Construction: {Construction}\n Discovered time: {DiscoveredTime}\n " +
            $"Culture: {Culture}\n Popularity: {WellKnowen}\n Benefits: {Benefits}\n " +
            $"Healthy: {Healthy}\n Population: {Population}\n Animals: {Animals}\n";

        Console.WriteLine(result);
    }

}

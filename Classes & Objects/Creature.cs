using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classes___Objects;

internal class Creature
{


    public string Creatures {get; set;}
    public string MentalActivity {get; set;}
    public string Living {get; set;}
    public string Homes {get; set;}
    public string Intuitions { get; set;}
    public string FeedingBabies {get; set;}
    public string Dangers {get; set;}
    public string Benefits {get; set;}
    public string AffectsForTheFuture {get; set;}
    public string DistinguishingFeature {get; set;}

    public void DisplayOfCreature()
    {
        string result = $" Creatures: {Creatures}\n MentalActivity: {MentalActivity}\n " +
            $"LifeStyle: {Living}\n Homes: {Homes}\n " +
            $"Intuitions: {Intuitions}\n FeedingBabies: {FeedingBabies}\n Dangers: {Dangers}\n " +
            $"Benefits: {Benefits}\n AffectsForTheFuture: {AffectsForTheFuture}\n DistinguishingFeature: {DistinguishingFeature}\n";

        Console.WriteLine(result);
    }
}

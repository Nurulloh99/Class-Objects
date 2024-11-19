using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects;

public class Games
{


    public string Name { get; set; } 
    public string CreatingTime { get; set; }
    public string Owner { get; set; }
    public string Brand { get; set; }
    public string Benifits { get; set; }
    public string Dangers { get; set; }
    public string Equipments { get; set; }
    public string Graphics { get; set; }
    public string Popularity { get; set; }
    public string FinancialBenefit { get; set; }



    public void DisplayOfGames()
    {
        string result = $" Name: {Name}\n CreatingTime: {CreatingTime}\n " +
            $"Owner: {Owner}\n Brand: {Brand}\n " +
            $"Benifits: {Benifits}\n Dangers: {Dangers}\n Equipments: {Equipments}\n " +
            $"Graphics: {Graphics}\n Popularity: {Popularity}\n FinancialBenefit: {FinancialBenefit}\n";

        Console.WriteLine(result);
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects;

public class Country
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
        string result = $" Davlat nomi: {Place}\n Ko'rinishi: {Appearence}\n " +
            $"Qurilish holati: {Construction}\n Tashkil topgan vaqt: {DiscoveredTime}\n " +
            $"Madaniyati: {Culture}\n Mashxur: {WellKnowen}\n Foydalasi: {Benefits}\n " +
            $"Sog'liqga tasiri: {Healthy}\n Aholisi: {Population}\n Hayvonlar: {Animals}\n";

        Console.WriteLine(result);
    }

}

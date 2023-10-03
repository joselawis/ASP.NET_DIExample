﻿using System.Collections.Generic;
namespace Services;

public class CitiesService
{
    private List<string> _cities;
    
    public CitiesService(){
        _cities = new List<string>(){
            "London",
            "Paris",
            "Torremolinos",
            "Alicante"
        };
    }

    public List<string> GetCities(){
        return _cities;
    }
}
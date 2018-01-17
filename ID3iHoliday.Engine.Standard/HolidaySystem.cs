﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ID3iHoliday.Engine;
using ID3iHoliday.Countries;

namespace ID3iHoliday.Engine.Standard
{
    /// <summary>
    /// Wrapper pour la récupération de données particulières dans l'environnement des jours particuliers.
    /// </summary>
    /// <remarks>Ce wrapper inclu déjà tous les pays possible et est founit avec son singleton.</remarks>
    public class HolidaySystem : Engine.HolidaySystem
    {
        /// <summary>
        /// Singleton.
        /// </summary>
        public static HolidaySystem Instance { get; } = new HolidaySystem();
        private HolidaySystem()
        {            
            CountriesAvailable.Add(new AD());
            CountriesAvailable.Add(new AG());
            CountriesAvailable.Add(new AI());
            CountriesAvailable.Add(new AL());
            CountriesAvailable.Add(new AT());
            CountriesAvailable.Add(new AX());
            CountriesAvailable.Add(new BA());
            CountriesAvailable.Add(new BE());
            CountriesAvailable.Add(new BG());
            CountriesAvailable.Add(new BY());
            CountriesAvailable.Add(new CY());
            CountriesAvailable.Add(new CZ());
            CountriesAvailable.Add(new DE());
            CountriesAvailable.Add(new DK());
            CountriesAvailable.Add(new EE());
            CountriesAvailable.Add(new FI());
            CountriesAvailable.Add(new FR());
            CountriesAvailable.Add(new HR());
        }
    }
}

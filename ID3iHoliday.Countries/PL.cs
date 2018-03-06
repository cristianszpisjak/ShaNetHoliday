﻿using ID3iCore;
using ID3iDate;
using ID3iHoliday.Models;
using ID3iHoliday.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.DayOfWeek;
using static ID3iHoliday.Syntax.Count;
using static ID3iHoliday.Syntax.Month;
using static ID3iHoliday.Models.RuleType;

namespace ID3iHoliday.Countries
{
    /// <summary>
    /// Définition pour Poland.
    /// </summary>
    public class PL : Country
    {
        /// <summary>
        /// Initialise une nouvelle instance pour la classe <see cref="PL"/>.
        /// </summary>
        public PL()
        {
            Code = "PL";
            Alpha3Code = "POL";
            Names = NamesBuilder.Make.Add(Langue.EN, "Poland").Add(Langue.PL, "Polska").AsDictionary();
            DaysOff.Add(Sunday);
            Langues.Add(Langue.PL);
            Rules = new ListRule()
            {
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The1st),
                    Names = NamesBuilder.Make.Add(Langue.PL, "Nowy Rok").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The6th),
                    Names = NamesBuilder.Make.Add(Langue.PL, "Święto Trzech Króli").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.Easter,
                    Names = NamesBuilder.Make.Add(Langue.PL, "Niedziela Wielkanocna").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.EasterMonday,
                    Names = NamesBuilder.Make.Add(Langue.PL, "Drugi dzień Wielkanocy").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The1st),
                    Names = NamesBuilder.Make.Add(Langue.PL, "Święto Państwowe; Święto Pracy").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The3rd),
                    Names = NamesBuilder.Make.Add(Langue.PL, "Święto Narodowe Trzeciego Maja").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The26th),
                    Names = NamesBuilder.Make.Add(Langue.PL, "Dzień Matki").AsDictionary(),
                    Type = Observance
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.Pentecost,
                    Names = NamesBuilder.Make.Add(Langue.PL, "Zielone Świątki").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.CorpusChristi,
                    Names = NamesBuilder.Make.Add(Langue.PL, "Dzień Bożego Ciała").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.August.The15th),
                    Names = NamesBuilder.Make.Add(Langue.PL, "Wniebowzięcie Najświętszej Maryi Panny").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.November.The1st),
                    Names = NamesBuilder.Make.Add(Langue.PL, "Wszystkich Świętych").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.November.The11th),
                    Names = NamesBuilder.Make.Add(Langue.PL, "Narodowe Święto Niepodległości").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The25th),
                    Names = NamesBuilder.Make.Add(Langue.PL, "Pierwszy dzień Bożego Narodzenia").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The26th),
                    Names = NamesBuilder.Make.Add(Langue.PL, "Drugi dzień Bożego Narodzenia").AsDictionary()
                }
            };
        }
    }
}
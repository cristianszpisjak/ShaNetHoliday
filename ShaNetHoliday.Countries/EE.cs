﻿using ShaNetHoliday.Syntax;
using ShaNetDate;
using ShaNetHoliday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.DayOfWeek;
using static ShaNetHoliday.Syntax.Count;
using static ShaNetHoliday.Syntax.Month;
using static ShaNetHoliday.Models.RuleType;
using static ShaNetHoliday.Models.Calendar;

namespace ShaNetHoliday.Countries
{
    /// <summary>
    /// Définition pour Estonia.
    /// </summary>
    public class EE : Country
    {
        /// <summary>
        /// Initialise une nouvelle instance pour la classe <see cref="EE"/>.
        /// </summary>
        public EE()
        {
            Code = "EE";
            Alpha3Code = "EST";
            Names = NamesBuilder.Make.Add(Langue.EN, "Estonia").Add(Langue.ET, "Eesti").AsDictionary();
            DaysOff.Add(Sunday);
            Langues.Add(Langue.ET);
            SupportedCalendar.Add(Gregorian);
            Rules = new ListRule()
            {
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The1st),
                    Names = NamesBuilder.Make.Add(Langue.ET, "uusaasta").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The6th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "kolmekuningapäev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.February.The2nd),
                    Names = NamesBuilder.Make.Add(Langue.ET, "Tartu rahulepingu aastapäev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.February.The24th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "iseseisvuspäev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.March.The14th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "emakeelepäev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.GoodFriday,
                    Names = NamesBuilder.Make.Add(Langue.ET, "suur reede").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.Easter,
                    Names = NamesBuilder.Make.Add(Langue.ET, "lihavõtted").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The1st),
                    Names = NamesBuilder.Make.Add(Langue.ET, "kevadpüha").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Movable(Second, Sunday).In(May),
                    Names = NamesBuilder.Make.Add(Langue.ET, "emadepäev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.Pentecost,
                    Names = NamesBuilder.Make.Add(Langue.ET, "nelipühade 1. püha").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.June.The4th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "Eesti lipu päev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.June.The14th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "leinapäev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.June.The23rd),
                    Names = NamesBuilder.Make.Add(Langue.ET, "võidupüha").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.June.The24th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "jaanipäev").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.August.The20th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "taasiseseisvumispäev").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.August.The23rd),
                    Names = NamesBuilder.Make.Add(Langue.ET, "kommunismi ja natsismi ohvrite mälestuspäev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Movable(Second, Sunday).In(September),
                    Names = NamesBuilder.Make.Add(Langue.ET, "vanavanemate päev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.September.The22nd),
                    Names = NamesBuilder.Make.Add(Langue.ET, "vastupanuvõitluse päev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.November.The2nd),
                    Names = NamesBuilder.Make.Add(Langue.ET, "hingedepäev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Movable(Second, Sunday).In(November),
                    Names = NamesBuilder.Make.Add(Langue.ET, "isadepäev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.November.The16th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "taassünni päev").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The24th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "jõululaupäev").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The25th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "esimene jõulupüha").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The26th),
                    Names = NamesBuilder.Make.Add(Langue.ET, "teine jõulupüha").AsDictionary()
                }
            };
        }
    }
}

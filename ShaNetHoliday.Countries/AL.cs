﻿using System;
using System.Collections.Generic;
using ShaNetDate;
using ShaNetHoliday.Models;
using ShaNetHoliday.Syntax;

using static System.DayOfWeek;
using static ShaNetHoliday.Models.RuleType;
using static ShaNetHoliday.Models.Calendar;

namespace ShaNetHoliday.Countries
{
    /// <summary>
    /// Définition pour Albania.
    /// </summary>
    public class AL : Country
    {
        /// <summary>
        /// Initialise une nouvelle instance pour la classe <see cref="AL"/>.
        /// </summary>
        public AL()
        {
            Code = "AL";
            Alpha3Code = "ALB";
            Names = NamesBuilder.Make.Add(Langue.EN, "Albania").Add(Langue.SQ, "Shqipëri").AsDictionary();
            DaysOff.Add(Sunday);
            Langues.Add(Langue.SQ);
            SupportedCalendar.Add(Gregorian);
            Rules = new ListRule()
            {
                new GregorianRule()
                {
                    Expression = ExpressionTree.Substitute.Fix(On.January.The1st).If(Sunday).Then.Next(Tuesday),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Viti i Ri").AsDictionary(),
                    Substitute = true
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Substitute.Fix(On.January.The2nd).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Festa e Vitit të Ri").AsDictionary(),
                    Substitute = true
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.March.The2nd),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Besëlidhjes së Lezhës").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.March.The7th),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Mësuesit").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.March.The8th),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Nënës").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.March.The14th).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Verës").AsDictionary(),
                    Substitute = true
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.March.The22nd).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Sulltan Nevruzit").AsDictionary(),
                    Substitute = true
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.April.The1st),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Gënjeshtrave").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.Easter,
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Pashkët Katolike").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.EasterMonday,
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Pashkët Katolike").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Orthodox.Easter,
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Pashkët Ortodokse").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Orthodox.EasterMonday,
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Pashkët Ortodokse").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.May.The1st).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita Ndërkombëtare e Punonjësve").AsDictionary(),
                    Substitute = true
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.June.The1st),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita Ndërkombëtare e Fëmijëve").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.October.The19th).If(Sunday).Then.Next(Monday).Since(2004),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Nënë Terezës").AsDictionary(),
                    Substitute = true,
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.November.The22nd),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Alfabetit").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.November.The28th).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Pavarësisë").AsDictionary(),
                    Substitute = true
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.November.The29th).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Çlirimit").AsDictionary(),
                    Substitute = true
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.December.The8th).If(Sunday).Then.Next(Monday).Since(2010),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita Kombëtare e Rinisë").AsDictionary(),
                    Substitute = true,
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The24th),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Nata e Krishtlindjes").AsDictionary(),
                    Type = Bank
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.December.The25th).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Krishtlindja").AsDictionary(),
                    Substitute = true
                },
                new HijriRule()
                {
                    Expression = ExpressionTree.Date.Fix(OnM.Shawwal.The1st).Over.Hijri(),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Fitër Bajrami").AsDictionary()
                },
                new HijriRule()
                {
                    Expression = ExpressionTree.Date.Fix(OnM.DhuAlHijjah.The10th).Over.Hijri(),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Kurban Bajrami").AsDictionary()
                }
            };
        }
    }
}

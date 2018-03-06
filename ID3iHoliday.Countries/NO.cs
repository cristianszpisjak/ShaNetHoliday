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
    /// Définition pour Norway.
    /// </summary>
    public class NO : Country
    {
        /// <summary>
        /// Initialise une nouvelle instance pour la classe <see cref="NO"/>.
        /// </summary>
        public NO()
        {
            Code = "NO";
            Alpha3Code = "NOR";
            Names = NamesBuilder.Make.Add(Langue.EN, "Norway").Add(Langue.NO, "Norge").AsDictionary();
            DaysOff.Add(Sunday);
            Langues.Add(Langue.NO);
            Rules = new ListRule()
            {
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The1st),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Første nyttårsdag").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Movable(Second, Sunday).In(February),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Morsdag").AsDictionary(),
                    Type = Observance
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.CustomDay("EASTER -49"),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Fastelavn").AsDictionary(),
                    Type = Observance
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.PalmSunday,
                    Names = NamesBuilder.Make.Add(Langue.NO, "Palmesøndag").AsDictionary(),
                    Type = Observance
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.MaundyThursday,
                    Names = NamesBuilder.Make.Add(Langue.NO, "Skjærtorsdag").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.GoodFriday,
                    Names = NamesBuilder.Make.Add(Langue.NO, "Langfredag").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.Easter,
                    Names = NamesBuilder.Make.Add(Langue.NO, "Første påskedag").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.EasterMonday,
                    Names = NamesBuilder.Make.Add(Langue.NO, "Andre påskedag").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The1st),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Første mai").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The8th),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Frigjøringsdag 1945").AsDictionary(),
                    Type = Observance
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The17th),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Grunnlovsdagen").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.AscensionDay,
                    Names = NamesBuilder.Make.Add(Langue.NO, "Kristi himmelfartsdag").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.Pentecost,
                    Names = NamesBuilder.Make.Add(Langue.NO, "Første pinsedag").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.WhitMonday,
                    Names = NamesBuilder.Make.Add(Langue.NO, "Andre pinsedag").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.June.The23rd),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Sankthansaften").AsDictionary(),
                    Type = Observance
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Movable(Fourth, Sunday).Before("12-24"),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Første søndag i advent").AsDictionary(),
                    Type = Observance
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The24th),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Julaften").AsDictionary(),
                    Type = Bank
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The25th),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Første Juledag").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The26th),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Andre juledag").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The31st).StartAt("14:00").UntilMidnight.If(Sunday).ThenStartAt("00:00"),
                    Names = NamesBuilder.Make.Add(Langue.NO, "Nyttårsaften").AsDictionary(),
                    Type = Bank
                }
            };
        }
    }
}
﻿using ID3iHoliday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.DayOfWeek;
using static ID3iHoliday.Syntax.Count;
using static ID3iHoliday.Syntax.Month;
using static ID3iHoliday.Models.RuleType;
using ID3iHoliday.Syntax;

namespace ID3iHoliday.Countries
{
    public class HR : Country
    {
        public HR()
        {
            Code = "HR";
            Alpha3Code = "HRV";
            Names = NamesBuilder.Make.Add(Langue.EN, "Croatia").Add(Langue.HR, "Hrvatska").AsDictionary();
            DaysOff.Add(Sunday);
            Langues.Add(Langue.HR);
            Rules = new ListRule()
            {
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The1st),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Nova godina").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The6th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Bogojavljenje, Sveta tri kralja").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.CarnivalTuesday,
                    Names = NamesBuilder.Make.Add(Langue.HR, "Pokladni utorak").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.Easter,
                    Names = NamesBuilder.Make.Add(Langue.HR, "Uskrs").AsDictionary(),
                    Type = Observance
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.EasterMonday,
                    Names = NamesBuilder.Make.Add(Langue.HR, "Drugi dan Uskrsa").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.CorpusChristi,
                    Names = NamesBuilder.Make.Add(Langue.HR, "Tijelovo").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The1st),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Praznik rada").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Movable(Second, Sunday).In(May),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Majčin dan").AsDictionary(),
                    Type = Observance
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.June.The22nd),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Dan antifašističke borbe").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.June.The25th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Dan državnosti").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.August.The5th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Dan pobjede i domovinske zahvalnosti").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.August.The15th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Velika Gospa").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.October.The8th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Dan neovisnosti").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.November.The1st),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Svi sveti").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The25th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Božić").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The26th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Svetog Stjepana").AsDictionary()
                }
            };
            States = new ListState()
            {
                Langues = Langues,
                Container = { new HR_17(), new HR_19() }
            }.Initialize(x => x.Init());
        }

        internal class HR_17 : State
        {
            public HR_17()
            {
                Code = "17";
                Names = NamesBuilder.Make.Add(Langue.EN, "Split-Dalmatia").AsDictionary();
                Rules = new ListRule()
                {
                    new Rule()
                    {
                        Expression = ExpressionTree.Date.Fix(On.May.The7th),
                        Names = NamesBuilder.Make.Add(Langue.HR, "Sveti Duje").AsDictionary()
                    }
                };
            }
        }
        internal class HR_19 : State
        {
            public HR_19()
            {
                Code = "19";
                Names = NamesBuilder.Make.Add(Langue.EN, "Dubrovnik-Neretva").AsDictionary();
                Rules = new ListRule()
                {
                    new Rule()
                    {
                        Expression = ExpressionTree.Date.Fix(On.February.The3rd),
                        Names = NamesBuilder.Make.Add(Langue.HR, "Sveti Vlaho").AsDictionary()
                    }
                };
            }
        }
    }
}
﻿using ID3iDate;
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
    /// Définition pour Kosovo.
    /// </summary>
    public class XK : Country
    {
#warning attention ici il faut penser aux jours fériés dans d'autres calendriers.
        /// <summary>
        /// Initialise une nouvelle instance pour la classe <see cref="XK"/>.
        /// </summary>
        public XK()
        {
            Code = "XK";
            Alpha3Code = "UNK";
            Names = NamesBuilder.Make.Add(Langue.EN, "Kosovo").Add(Langue.SQ, "Republika e Kosovës").Add(Langue.SR, "Република Косово").AsDictionary();
            DaysOff.Add(Sunday);
            Langues = new List<Langue>() { Langue.SQ, Langue.SR };
            Rules = new ListRule()
            {
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The1st),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Viti i Ri")
                                             .Add(Langue.SR, "Нова година").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.February.The17th),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Pavarësisë")
                                             .Add(Langue.SR, "Дан независности").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.April.The9th),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Kushtetutës").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.Easter,
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Pashkët Katolike")
                                             .Add(Langue.SR, "Католички Васкрс").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Orthodox.Easter,
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Pashkët Ortodokse")
                                             .Add(Langue.SR, "Васкрс").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The1st),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita Ndërkombëtare e Punonjësve")
                                             .Add(Langue.SR, "Празник рада").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The9th),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Dita e Evropës").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The25th),
                    Names = NamesBuilder.Make.Add(Langue.SQ, "Krishtlindja")
                                             .Add(Langue.SR, "Католички Божић").AsDictionary()
                }
            };
        }
    }
}
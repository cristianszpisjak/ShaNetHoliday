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
using static ID3iHoliday.Syntax.Calendar;

#warning Penser aux jours fériés dans les autres types de calendriers.
namespace ID3iHoliday.Countries
{
    /// <summary>
    /// Définition pour Montenegro.
    /// </summary>
    public class ME : Country
    {
        /// <summary>
        /// Initialise une nouvelle instance pour la classe <see cref="ME"/>.
        /// </summary>
        public ME()
        {
            Code = "ME";
            Alpha3Code = "MNE";
            Names = NamesBuilder.Make.Add(Langue.EN, "Montenegro").Add(Langue.HR, "Crna Gora").Add(Langue.SR, "Црна Гора").Add(Langue.BS, "Crna Gora").Add(Langue.SQ, "Mali i Zi").AsDictionary();
            DaysOff.Add(Sunday);
            Langues = new List<Langue>() { Langue.HR, Langue.SR, Langue.BS, Langue.SQ };
            Rules = new ListRule()
            {
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The1st).Over(Julian),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Pravoslavna Nova Godina")
                                             .Add(Langue.SR, "Православна Нова година")
                                             .Add(Langue.BS, "Pravoslavni novogodišnji dan")
                                             .Add(Langue.SQ, "Viti i Ri Ortodoks").AsDictionary(),
                },
                new Rule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.May.The21st).If(Sunday).Then.Next(Tuesday),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Dan neovisnosti")
                                             .Add(Langue.SR, "Дан независности")
                                             .Add(Langue.BS, "Dan nezavisnosti")
                                             .Add(Langue.SQ, "Dita e Pavarësisë").AsDictionary(),
                    Substitute = true
                },
                new Rule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.May.The22nd).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Dan neovisnosti")
                                             .Add(Langue.SR, "Дан независности")
                                             .Add(Langue.BS, "Dan nezavisnosti")
                                             .Add(Langue.SQ, "Dita e Pavarësisë").AsDictionary(),
                    Substitute = true
                },
                new Rule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.July.The13th).If(Sunday).Then.Next(Tuesday),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Dan državnosti")
                                             .Add(Langue.SR, "Дан државности").AsDictionary(),
                    Substitute = true
                },
                new Rule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.July.The14th).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Dan državnosti")
                                             .Add(Langue.SR, "Дан државности").AsDictionary(),
                    Substitute = true
                },
                new Rule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.January.The1st).If(Sunday).Then.Next(Tuesday),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Nova godina")
                                             .Add(Langue.SR, "Нова година")
                                             .Add(Langue.BS, "Novogodisnji dan")
                                             .Add(Langue.SQ, "Viti i Ri").AsDictionary(),
                    Substitute = true
                },
                new Rule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.January.The2nd).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Nova godina")
                                             .Add(Langue.SR, "Нова година")
                                             .Add(Langue.BS, "Novogodisnji dan")
                                             .Add(Langue.SQ, "Viti i Ri").AsDictionary(),
                    Substitute = true
                },
                new Rule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.May.The1st).If(Sunday).Then.Next(Tuesday),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Praznik rada")
                                             .Add(Langue.SR, "Празник рада")
                                             .Add(Langue.BS, "Radni dan")
                                             .Add(Langue.SQ, "Dita Ndërkombëtare e Punonjësve").AsDictionary(),
                    Substitute = true
                },
                new Rule()
                {
                    Expression = ExpressionTree.Observe.Fix(On.May.The2nd).If(Sunday).Then.Next(Monday),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Praznik rada")
                                             .Add(Langue.SR, "Празник рада")
                                             .Add(Langue.BS, "Radni dan")
                                             .Add(Langue.SQ, "Dita Ndërkombëtare e Punonjësve").AsDictionary(),
                    Substitute = true
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Orthodox.GoodFriday,
                    Names = NamesBuilder.Make.Add(Langue.HR, "Veliki petak")
                                             .Add(Langue.SR, "Велики петак")
                                             .Add(Langue.BS, "Dobar petak")
                                             .Add(Langue.SQ, "E Premtja e Madhe").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Orthodox.Easter,
                    Names = NamesBuilder.Make.Add(Langue.HR, "Uskrs")
                                             .Add(Langue.SR, "Католички Васкрс")
                                             .Add(Langue.BS, "Vaskrs")
                                             .Add(Langue.SQ, "Pashkët Katolike").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The24th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Badnji dan")
                                             .Add(Langue.SR, "Бадњи дан")
                                             .Add(Langue.BS, "Badnji dan")
                                             .Add(Langue.SQ, "Nata e Krishtlindjes").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The24th).Over(Julian),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Badnji dan")
                                             .Add(Langue.SR, "Бадњи дан")
                                             .Add(Langue.BS, "Badnji dan")
                                             .Add(Langue.SQ, "Nata e Krishtlindjes").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The25th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Božić")
                                             .Add(Langue.SR, "Католички Божић")
                                             .Add(Langue.BS, "Božić")
                                             .Add(Langue.SQ, "Krishtlindja").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The25th).Over(Julian),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Božić")
                                             .Add(Langue.SR, "Католички Божић")
                                             .Add(Langue.BS, "Božić")
                                             .Add(Langue.SQ, "Krishtlindja").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The26th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Svetog Stjepana").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The26th).Over(Julian),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Svetog Stjepana").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.GoodFriday,
                    Names = NamesBuilder.Make.Add(Langue.HR, "Veliki petak")
                                             .Add(Langue.SR, "Велики петак")
                                             .Add(Langue.BS, "Dobar petak")
                                             .Add(Langue.SQ, "E Premtja e Madhe").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.Easter,
                    Names = NamesBuilder.Make.Add(Langue.HR, "Uskrs")
                                             .Add(Langue.SR, "Католички Васкрс")
                                             .Add(Langue.BS, "Vaskrs")
                                             .Add(Langue.SQ, "Pashkët Katolike").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Catholic.EasterMonday,
                    Names = NamesBuilder.Make.Add(Langue.HR, "Drugi dan Uskrsa")
                                             .Add(Langue.SR, "Католички Васкрсни понедељак")
                                             .Add(Langue.BS, "Uskrsni ponedjeljak").AsDictionary()
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.August.The15th),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Velika Gospa")
                                             .Add(Langue.SQ, "Shën Mëria e Gushtit").AsDictionary(),
                    Type = Observance
                },
                new Rule()
                {
                    Expression = ExpressionTree.Date.Fix(On.November.The1st),
                    Names = NamesBuilder.Make.Add(Langue.HR, "Svi sveti")
                                             .Add(Langue.SR, "Сви Свети")
                                             .Add(Langue.BS, "Dita e të gjithë Shenjtorëve")
                                             .Add(Langue.SQ, "Të gjitha Saints").AsDictionary()
                }
            };
        }
    }
}

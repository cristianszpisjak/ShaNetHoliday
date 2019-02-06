﻿using iD3iHoliday.Syntax;
using iD3iCore;
using iD3iDate;
using iD3iHoliday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.DayOfWeek;
using static iD3iHoliday.Syntax.Count;
using static iD3iHoliday.Syntax.Month;
using static iD3iHoliday.Models.RuleType;
using static iD3iHoliday.Models.Calendar;

namespace iD3iHoliday.Countries
{
    public class AE : Country
    {
        public AE()
        {
            Code = "AE";
            Alpha3Code = "ARE";
            Names = NamesBuilder.Make.Add(Langue.EN, "United Arab Emirates").Add(Langue.AR, "دولة الإمارات العربية المتحدة").AsDictionary();
            DaysOff.Add(Sunday);
            Langues = new List<Langue>() { Langue.AR };
            SupportedCalendar.AddRange(Gregorian, Hijri);
            Rules = new ListRule()
            {
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The1st),
                    Names = NamesBuilder.Make.Add(Langue.AR, "رأس السنة الميلادية").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The2nd),
                    Names = NamesBuilder.Make.Add(Langue.AR, "اليوم الوطني").AsDictionary()
                },
                new HijriRule()
                {
                    Expression = ExpressionTree.Date.Fix(OnM.Muharram.The1st).Over.Hijri(),
                    Names = NamesBuilder.Make.Add(Langue.AR, "رأس السنة الهجرية").AsDictionary()
                },
                new HijriRule()
                {
                    Expression = ExpressionTree.Date.Fix(OnM.Shawwal.The1st).StartAtMidnight.Duration.P3D().Over.Hijri(),
                    Names = NamesBuilder.Make.Add(Langue.AR, "عيد الفطر").AsDictionary()
                },
                new HijriRule()
                {
                    Expression = ExpressionTree.Date.Fix(OnM.DhuAlHijjah.The10th).StartAtMidnight.Duration.P3D().Over.Hijri(),
                    Names = NamesBuilder.Make.Add(Langue.AR, "عيد الأضحى").AsDictionary()
                },
                new HijriRule()
                {
                    Expression = ExpressionTree.Date.Fix(OnM.Rajab.The27th),
                    Names = NamesBuilder.Make.Add(Langue.AR, "الإسراء والمعراج").AsDictionary()
                },
                new HijriRule()
                {
                    Expression = ExpressionTree.Date.Fix(OnM.Ramadan.The1st),
                    Names = NamesBuilder.Make.Add(Langue.AR, "اليوم الأول من رمضان").AsDictionary()
                },
                new HijriRule()
                {
                    Expression = ExpressionTree.Date.Fix(OnM.RabiAlAwwal.The12th),
                    Names = NamesBuilder.Make.Add(Langue.AR, "المولد النبويّ").AsDictionary()
                }
            };
        }
    }
}

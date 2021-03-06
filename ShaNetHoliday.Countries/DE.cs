﻿using ShaNetCore;
using ShaNetDate;
using ShaNetHoliday.Models;
using ShaNetHoliday.Syntax;
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
    /// Définition pour Germany.
    /// </summary>
    public class DE : Country
    {
        /// <summary>
        /// Initialise une nouvelle instance pour la classe <see cref="DE"/>.
        /// </summary>
        public DE()
        {
            Code = "DE";
            Alpha3Code = "DEU";
            Names = NamesBuilder.Make.Add(Langue.EN, "Germany").Add(Langue.DE, "Deutschland").AsDictionary();
            DaysOff.Add(Sunday);
            Langues.Add(Langue.DE);
            SupportedCalendar.Add(Gregorian);
            Rules = new ListRule()
            {
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.January.The1st),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Neujahr").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.February.The14th),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Valentinstag").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.CustomDay("EASTER -52"),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Weiberfastnacht").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.CarnivalMonday,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Rosenmontag").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.CarnivalTuesday.StartAt("14:00"),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Faschingsdienstag").AsDictionary(),
                    Type = Bank
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.AshWednesday,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Aschermittwoch").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Key = "MaundyThursday",
                    Expression = ExpressionTree.Date.Catholic.MaundyThursday,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Gründonnerstag").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.GoodFriday,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Karfreitag").AsDictionary()
                },
                new GregorianRule()
                {
                    Key = "Easter",
                    Expression = ExpressionTree.Date.Catholic.Easter,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Ostersonntag").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.EasterMonday,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Ostermontag").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.May.The1st),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Tag der Arbeit").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Movable(Second, Sunday).In(May),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Muttertag").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.AscensionDay,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Christi Himmelfahrt").AsDictionary()
                },
                new GregorianRule()
                {
                    Key = "Pentecost",
                    Expression = ExpressionTree.Date.Catholic.Pentecost,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Pfingstsonntag").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Catholic.WhitMonday,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Pfingstmontag").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.October.The3rd),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Nationalfeiertag").AsDictionary()
                },
                new GregorianRule()
                {
                    Key = "NOV01",
                    Expression = ExpressionTree.Date.Fix(On.November.The1st),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Allerheiligen").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.November.The2nd),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Allerseelen").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.November.The11th),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Sankt Martin (Faschingsbeginn)").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Key = "B&B",
                    Expression = ExpressionTree.Date.Movable(First, Wednesday).Before("11-23"),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Buß- und Bettag").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Movable(Sixth, Sunday).Before("12-25"),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Volkstrauertag").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Movable(Fifth, Sunday).Before("12-25"),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Totensonntag").AsDictionary(),
                    Type = Observance
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The24th).StartAt2PM.UntilMidnight.If(Sunday).ThenStartAtMidnight,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Heiliger Abend").AsDictionary(),
                    Type = Bank,
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The25th),
                    Names = NamesBuilder.Make.Add(Langue.DE, "1. Weihnachtstag").AsDictionary()
                },
                new GregorianRule()
                {
                    Expression = ExpressionTree.Date.Fix(On.December.The26th),
                    Names = NamesBuilder.Make.Add(Langue.DE, "2. Weihnachtstag").AsDictionary()
                },
                new GregorianRule()
                {
                    Key = "DEC31",
                    Expression = ExpressionTree.Date.Fix(On.December.The31st).StartAt2PM.UntilMidnight.If(Sunday).ThenStartAtMidnight,
                    Names = NamesBuilder.Make.Add(Langue.DE, "Silvester").AsDictionary(),
                    Type = Bank,
                },
                new GregorianRule()
                {
                    Key = "OCT31",
                    Expression = ExpressionTree.Date.Specific(On.October.The31st.Of(2017)),
                    Names = NamesBuilder.Make.Add(Langue.DE, "Reformation Day").AsDictionary()
                }
            };
            States = new ListState()
            {
                Parent = this,
                Langues = Langues,
                Container = { new DE_BB(), new DE_BE(), new DE_BW(), new DE_BY(), new DE_HB(), new DE_HE(), new DE_MV(), new DE_NW(), new DE_RP(), new DE_SL(),
                                new DE_SN(), new DE_ST(), new DE_TH() }
            }.Initialize(x => x.Init());
        }
        internal class DE_BB : State
        {
            public DE_BB()
            {
                Code = "DE-BB";
                Names = NamesBuilder.Make.Add(Langue.DE, "Brandenburg").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Key = "Easter",
                        Type = Public,
                        Overrides = Overrides.Type
                    },
                    new GregorianRule()
                    {
                        Key = "Pentecost",
                        Type = Public,
                        Overrides = Overrides.Type
                    },
                    new GregorianRule()
                    {
                        Key = "OCT31",
                        Expression = ExpressionTree.Date.Fix(On.October.The31st),
                        Overrides = Overrides.Expression
                    }
                };
            }
        }
        internal class DE_BE : State
        {
            public DE_BE()
            {
                Code = "DE-BE";
                Names = NamesBuilder.Make.Add(Langue.DE, "Berlin").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Key = "Easter",
                        Type = Observance,
                        Overrides = Overrides.Type
                    },
                    new GregorianRule()
                    {
                        Key = "Pentecost",
                        Type = Observance,
                        Overrides = Overrides.Type
                    }
                };
            }
        }
        internal class DE_BW : State
        {
            public DE_BW()
            {
                Code = "DE-BW";
                Names = NamesBuilder.Make.Add(Langue.DE, "Baden Würtemberg").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Fix(On.January.The6th),
                        Names = NamesBuilder.Make.Add(Langue.DE, "Heilige Drei Könige").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Key = "MaundyThursday",
                        Type = School,
                        Overrides = Overrides.Type
                    },
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Catholic.CorpusChristi,
                        Names = NamesBuilder.Make.Add(Langue.DE, "Fronleichnam").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Key = "OCT31",
                        Expression = ExpressionTree.Date.Fix(On.October.The31st),
                        Type = School,
                        Overrides = Overrides.Expression | Overrides.Type
                    },
                    new GregorianRule()
                    {
                        Key = "NOV01",
                        Type = Public,
                        Overrides = Overrides.Type
                    }
                };
            }
        }
        internal class DE_BY : State
        {
            public DE_BY()
            {
                Code = "DE-BY";
                Names = NamesBuilder.Make.Add(Langue.DE, "Bayern").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Fix(On.January.The6th),
                        Names = NamesBuilder.Make.Add(Langue.DE, "Heilige Drei Könige").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Fix(On.February.The2nd),
                        Names = NamesBuilder.Make.Add(Langue.DE, "Lichtmess").AsDictionary(),
                        Type = Observance
                    },
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Catholic.CorpusChristi,
                        Names = NamesBuilder.Make.Add(Langue.DE, "Fronleichnam").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Key = "AUG15",
                        Expression = ExpressionTree.Date.Fix(On.August.The15th),
                        Names = NamesBuilder.Make.Add(Langue.DE, "Mariä Himmelfahrt").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Key = "NOV01",
                        Type = Public,
                        Overrides = Overrides.Type
                    },
                    new GregorianRule()
                    {
                        Key = "B&B",
                        Type = School,
                        Overrides = Overrides.Type
                    }
                };
                Regions = new ListRegion()
                {
                    Parent = this,
                    Langues = Langues,
                    Container = { new DE_BY_A(), new DE_BY_EVANG() }
                }.Initialize(x => x.Init());
            }
            internal class DE_BY_A : Region
            {
                public DE_BY_A()
                {
                    Code = "DE-BY-A";
                    Names = NamesBuilder.Make.Add(Langue.DE, "Stadt Augsburg").AsDictionary();
                    Rules = new ListRule()
                    {
                        new GregorianRule()
                        {
                            Expression = ExpressionTree.Date.Fix(On.August.The8th),
                            Names = NamesBuilder.Make.Add(Langue.DE, "Augsburger Friedensfest").AsDictionary()
                        }
                    };
                }
            }
            internal class DE_BY_EVANG : Region
            {
                public DE_BY_EVANG()
                {
                    Code = "DE-BY-EVANG";
                    Names = NamesBuilder.Make.Add(Langue.DE, "Überwiegend evangelische Gemeinden").AsDictionary();
                    Rules = new ListRule()
                    {
                        new GregorianRule()
                        {
                            Key = "AUG15",
                            Type = School,
                            Overrides = Overrides.Type
                        }
                    };
                }
            }
        }
        internal class DE_HB : State
        {
            public DE_HB()
            {
                Code = "DE-HB";
                Names = NamesBuilder.Make.Add(Langue.DE, "Hansestadt Bremen").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Key = "DEC31",
                        Type = Public,
                        Overrides = Overrides.Type
                    }
                };
            }
        }
        internal class DE_HE : State
        {
            public DE_HE()
            {
                Code = "DE-HE";
                Names = NamesBuilder.Make.Add(Langue.DE, "Hessen").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Catholic.CorpusChristi,
                        Names = NamesBuilder.Make.Add(Langue.DE, "Fronleichnam").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Key = "DEC31",
                        Type = Public,
                        Overrides = Overrides.Type
                    }
                };
            }
        }
        internal class DE_MV : State
        {
            public DE_MV()
            {
                Code = "DE-MV";
                Names = NamesBuilder.Make.Add(Langue.DE, "Mecklenburg Vorpommern").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Key = "OCT31",
                        Expression = ExpressionTree.Date.Fix(On.October.The31st),
                        Overrides = Overrides.Expression
                    }
                };
            }
        }
        internal class DE_NW : State
        {
            public DE_NW()
            {
                Code = "DE-NW";
                Names = NamesBuilder.Make.Add(Langue.DE, "Nordrhein-Westfalen").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Catholic.CorpusChristi,
                        Names = NamesBuilder.Make.Add(Langue.DE, "Fronleichnam").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Key = "NOV01",
                        Type = Public,
                        Overrides = Overrides.Type
                    }
                };
            }
        }
        internal class DE_RP : State
        {
            public DE_RP()
            {
                Code = "DE-RP";
                Names = NamesBuilder.Make.Add(Langue.DE, "Rheinland-Pfalz").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Catholic.CorpusChristi,
                        Names = NamesBuilder.Make.Add(Langue.DE, "Fronleichnam").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Key = "NOV01",
                        Type = Public,
                        Overrides = Overrides.Type
                    }
                };
            }
        }
        internal class DE_SL : State
        {
            public DE_SL()
            {
                Code = "DE-SL";
                Names = NamesBuilder.Make.Add(Langue.DE, "Saarland").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Catholic.CorpusChristi,
                        Names = NamesBuilder.Make.Add(Langue.DE, "Fronleichnam").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Fix(On.August.The15th),
                        Names = NamesBuilder.Make.Add(Langue.DE, "Mariä Himmelfahrt").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Key = "NOV01",
                        Type = Public,
                        Overrides = Overrides.Type
                    }
                };
            }
        }
        internal class DE_SN : State
        {
            public DE_SN()
            {
                Code = "DE-SN";
                Names = NamesBuilder.Make.Add(Langue.DE, "Sachsen").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Key = "CorpusChristi",
                        Expression = ExpressionTree.Date.Catholic.CorpusChristi,
                        Names = NamesBuilder.Make.Add(Langue.DE, "Fronleichnam").AsDictionary(),
                        Type = Observance
                    },
                    new GregorianRule()
                    {
                        Key = "OCT31",
                        Expression = ExpressionTree.Date.Fix(On.October.The31st),
                        Overrides = Overrides.Expression
                    },
                    new GregorianRule()
                    {
                        Key = "B&B",
                        Type = Public,
                        Overrides = Overrides.Type
                    }
                };
                Regions = new ListRegion()
                {
                    Parent = this,
                    Langues = Langues,
                    Container = { new DE_SN_BZ() }
                }.Initialize(x => x.Init());
            }
            internal class DE_SN_BZ : Region
            {
                public DE_SN_BZ()
                {
                    Code = "DE-SN-BZ";
                    Names = NamesBuilder.Make.Add(Langue.DE, "Landkreis Bautzen").AsDictionary();
                    Rules = new ListRule()
                    {
                        new GregorianRule()
                        {
                            Key = "CorpusChristi",
                            Type = Public,
                            Note = "Bautzen (nur in den Ortsteilen Bolbritz und Salzenforst), Crostwitz, Göda (nur im Ortsteil Prischwitz), Großdubrau (nur im Ortsteil Sdier), Hoyerswerda (nur im Ortsteil Dörgenhausen), Königswartha (nicht im Ortsteil Wartha), Nebelschütz, Neschwitz (nur in den Ortsteilen Neschwitz und Saritsch), Panschwitz-Kuckau, Puschwitz, Räckelwitz, Radibor, Ralbitz-Rosenthal und Wittichenau.",
                            Overrides = Overrides.Type | Overrides.Note
                        }
                    };
                }
            }
        }
        internal class DE_ST : State
        {
            public DE_ST()
            {
                Code = "DE-ST";
                Names = NamesBuilder.Make.Add(Langue.DE, "Sachsen-Anhalt").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Expression = ExpressionTree.Date.Fix(On.January.The6th),
                        Names = NamesBuilder.Make.Add(Langue.DE, "Heilige Drei Könige").AsDictionary()
                    },
                    new GregorianRule()
                    {
                        Key = "OCT31",
                        Expression = ExpressionTree.Date.Fix(On.October.The31st),
                        Overrides = Overrides.Expression
                    }
                };
            }
        }
        internal class DE_TH : State
        {
            public DE_TH()
            {
                Code = "DE-TH";
                Names = NamesBuilder.Make.Add(Langue.DE, "Thüringen").AsDictionary();
                Rules = new ListRule()
                {
                    new GregorianRule()
                    {
                        Key = "CorpusChristi",
                        Expression = ExpressionTree.Date.Catholic.CorpusChristi,
                        Names = NamesBuilder.Make.Add(Langue.DE, "Fronleichnam").AsDictionary(),
                        Type = Observance
                    },
                    new GregorianRule()
                    {
                        Key = "OCT31",
                        Expression = ExpressionTree.Date.Fix(On.October.The31st),
                        Overrides = Overrides.Expression
                    },
                    new GregorianRule()
                    {
                        Key = "DEC31",
                        Type = Public,
                        Overrides = Overrides.Type
                    }
                };
                Regions = new ListRegion()
                {
                    Parent = this,
                    Langues = Langues,
                    Container = { new DE_TH_EIC(), new DE_TH_UH(), new DE_TH_WAK() }
                }.Initialize(x => x.Init());
            }
            internal class DE_TH_EIC : Region
            {
                public DE_TH_EIC()
                {
                    Code = "DE-TH-EIC";
                    Names = NamesBuilder.Make.Add(Langue.DE, "Landkreis Eichfeld").AsDictionary();
                    Rules = new ListRule()
                    {
                        new GregorianRule()
                        {
                            Key = "CorpusChristi",                            
                            Type = Public,
                            Overrides = Overrides.Type
                        }
                    };
                }
            }
            internal class DE_TH_UH : Region
            {
                public DE_TH_UH()
                {
                    Code = "DE-TH-UH";
                    Names = NamesBuilder.Make.Add(Langue.DE, "Unstrut-Hainich-Kreis").AsDictionary();
                    Rules = new ListRule()
                    {
                        new GregorianRule()
                        {
                            Key = "CorpusChristi",
                            Type = Public,
                            Note = "In Anrode (nur in den Ortsteilen Bickenriede und Zella), Dünwald (nur in den Ortsteilen Beberstedt und Hüpstedt), Rodeberg (nur im Ortsteil Struth), Südeichsfeld",
                            Overrides = Overrides.Type | Overrides.Note
                        }
                    };
                }
            }
            internal class DE_TH_WAK : Region
            {
                public DE_TH_WAK()
                {
                    Code = "DE-TH-WAK";
                    Names = NamesBuilder.Make.Add(Langue.DE, "Wartburgkreis").AsDictionary();
                    Rules = new ListRule()
                    {
                        new GregorianRule()
                        {
                            Key = "CorpusChristi",
                            Type = Public,
                            Note = "In Brunnhartshausen (nur in den Ortsteilen Föhlritz und Steinberg), Buttlar, Geisa, Schleid, Zella/Rhön",
                            Overrides = Overrides.Type | Overrides.Note
                        }
                    };
                }
            }
        }
    }
}

﻿using ID3iRegex;
using System;
using System.Text.RegularExpressions;
using ID3iHoliday.Core.Parsers;

using static ID3iHoliday.Syntax.Year;

namespace ID3iHoliday.Syntax.Parsers
{
    public class ParserMovableFromMovable : ParserBase
    {
        public Pattern Pattern =>
            Pattern.With
                .StartOfLine
                .Literal("DATE").Whitespace.Literal("MOVABLE²").Whitespace
                .NamedGroup("ExpectedNumber", Parser.PatternNumber)
                .Whitespace
                .NamedGroup("Expected", Parser.PatternDay)
                .Whitespace
                .NamedGroup("ExpectedAction", Parser.PatternActionBeforeAfter)
                .Whitespace
                .NamedGroup("BaseNumber", Parser.PatternNumber)
                .Whitespace
                .NamedGroup("Base", Parser.PatternDay)
                .Whitespace
                .NamedGroup("BaseAction", Parser.PatternActionBeforeAfter)
                .Whitespace
                .Include(Parser.PatternMonths)
                .Include(Parser.PatternYearType)
                .Include(Parser.PatternYearRecurs)
                .EndOfLine;
        public override ParserResult Parse(string expression, int year)
        {
            ParserResult result = new ParserResult();
            var regex = new Regex(Pattern.ToString());
            var match = regex.Match(expression);
            if (match.Success)
            {
                var date = new DateTime(year, Int32.Parse(match.Groups["month"].Value), Int32.Parse(match.Groups["day"].Value));
                if (match.Groups["BaseAction"].Value == "BEFORE")
                    date = date.Previous((DayOfWeek)Enum.Parse(typeof(DayOfWeek), match.Groups["Base"].Value, true)).WeekEarlier((int)(Count)Enum.Parse(typeof(Count), match.Groups["BaseNumber"].Value, true));
                else if (match.Groups["BaseAction"].Value == "AFTER")
                    date = date.NextOrThis((DayOfWeek)Enum.Parse(typeof(DayOfWeek), match.Groups["Base"].Value, true)).WeekAfter((int)(Count)Enum.Parse(typeof(Count), match.Groups["BaseNumber"].Value, true));

                if (match.Groups["ExpectedAction"].Value == "BEFORE")
                    date = date.Previous((DayOfWeek)Enum.Parse(typeof(DayOfWeek), match.Groups["Expected"].Value, true)).WeekEarlier((int)(Count)Enum.Parse(typeof(Count), match.Groups["ExpectedNumber"].Value, true));
                else if (match.Groups["ExpectedAction"].Value == "AFTER")
                    date = date.NextOrThis((DayOfWeek)Enum.Parse(typeof(DayOfWeek), match.Groups["Expected"].Value, true)).WeekAfter((int)(Count)Enum.Parse(typeof(Count), match.Groups["ExpectedNumber"].Value, true));

                if (match.Groups["YearType"].Value.IsNotNullOrEmpty())
                {
                    switch ((Year)Enum.Parse(typeof(Year), match.Groups["YearType"].Value, true))
                    {
                        case Even:
                            if (date.Year % 2 == 0)
                                result.DatesToAdd.Add(date);
                            break;
                        case Odd:
                            if (date.Year % 2 != 0)
                                result.DatesToAdd.Add(date);
                            break;
                        case Leap:
                            if (DateTime.IsLeapYear(date.Year))
                                result.DatesToAdd.Add(date);
                            break;
                        case NonLeap:
                            if (!DateTime.IsLeapYear(date.Year))
                                result.DatesToAdd.Add(date);
                            break;
                    }
                }
                else if (match.Groups["RepeatYear"].Value.IsNotNullOrEmpty() && match.Groups["RepeatStartYear"].Value.IsNotNullOrEmpty())
                {
                    var numberYear = Int32.Parse(match.Groups["RepeatYear"].Value);
                    var startYear = Int32.Parse(match.Groups["RepeatStartYear"].Value);
                    if (((date.Year - startYear) % numberYear) == 0)
                        result.DatesToAdd.Add(date);
                }
                else
                    result.DatesToAdd.Add(date);
            }
            return result;
        }
    }
}
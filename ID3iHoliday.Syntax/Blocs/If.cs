﻿using ID3iHoliday.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3iHoliday.Syntax
{
    public class If : ExpressionElement
    {
        protected override string Token => $"IF {Day.ToString().ToUpper()}";
        internal DayOfWeek Day { get; set; }
        public If(ExpressionElement parent, DayOfWeek day) : base(parent) { Day = day; }
    }
}
﻿using ID3iHoliday.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3iHoliday.Syntax
{
    /// <summary>
    /// Elément de syntax pour déplacer le jour à un autre si il tombe un certain jour.
    /// </summary>
    public class IfDayComposition : ExpressionElement
    {
        /// <summary>
        /// Token de l'élément.
        /// </summary>
        protected override string Token => $"IF {DayOfWeek.ToString().ToUpper()}";
        internal DayOfWeek DayOfWeek { get; set; }
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="IfDayComposition"/>.
        /// </summary>
        /// <param name="parent">Elément de syntax parent.</param>
        /// <param name="dayOfWeek">Jour particulier.</param>
        public IfDayComposition(ExpressionElement parent, DayOfWeek dayOfWeek) : base(parent) => DayOfWeek = dayOfWeek;
        /// <summary>
        /// Elément de syntax <see cref="ThenActionComposition"/> pour choisir l'action à réaliser.
        /// </summary>
        public ThenActionComposition Then { get; set; }
    }
}
﻿using ShaNetHoliday.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaNetHoliday.Syntax.Composition
{
    /// <summary>
    /// Elément de syntax pour gérer le calendrier à utiliser pour interpréter la date.
    /// </summary>
    public class Over : ExpressionElement
    {
        /// <summary>
        /// Token de l'élément.
        /// </summary>
        protected override string Token => $"OVER {Calendar.ToUpper()}";
        internal string Calendar { get; set; }

        /// <summary>
        /// Affecte le calendrier <see cref="System.Globalization.GregorianCalendar"/> à cette expression.
        /// </summary>
        /// <returns>L'expression.</returns>
        public ExpressionElement Gregorian()
        {
            Calendar = nameof( Gregorian );
            return this;
        }

        /// <summary>
        /// Affecte le calendrier <see cref="System.Globalization.JulianCalendar"/> à cette expression.
        /// </summary>
        /// <returns>L'expression.</returns>
        public ExpressionElement Julian()
        {
            Calendar = nameof( Julian );
            return this;
        }

        /// <summary>
        /// Affecte le calendrier <see cref="System.Globalization.HijriCalendar"/> à cette expression.
        /// </summary>
        /// <returns>L'expression.</returns>
        public ExpressionElement Hijri()
        {
            Calendar = nameof( Hijri );
            return this;
        }

        /// <summary>
        /// Affecte le calendrier <see cref="System.Globalization.HebrewCalendar"/> à cette expression.
        /// </summary>
        /// <returns>L'expression.</returns>
        public ExpressionElement Hebrew()
        {
            Calendar = nameof( Hebrew );
            return this;
        }

        /// <summary>
        /// Initialise une nouvelle instance pour la classe <see cref="Over"/>.
        /// </summary>
        /// <param name="parent">Elément de syntax parent.</param>
        public Over( ExpressionElement parent ) : base( parent ) { }
    }
}

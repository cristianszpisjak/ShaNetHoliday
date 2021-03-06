﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaNetHoliday.Core.Parsers
{
    /// <summary>
    /// Résultat du parsing d'une expression.
    /// </summary>
    public class ParserResult
    {
        /// <summary>
        /// Dates correspondantes à l'expression.
        /// </summary>
        public List<DateTime> DatesToAdd { get; set; } = new List<DateTime>();

        /// <summary>
        /// Date à supprimer.
        /// </summary>
        public DateTime? DateToRemove { get; set; }
    }
}

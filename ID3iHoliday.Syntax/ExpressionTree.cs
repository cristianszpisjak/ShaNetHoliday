﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID3iHoliday.Syntax
{
    /// <summary>
    /// Racine de la syntax pour les expressions.
    /// </summary>
    public static class ExpressionTree
    {
        /// <summary>
        /// Racine pour les expressions de date.
        /// </summary>
        public static Date Date => new Date();
        /// <summary>
        /// Racine pour les expressions de déplacement.
        /// </summary>
        public static Move Move => new Move();
        /// <summary>
        /// Racine pour les expressions d'observation.
        /// </summary>
        public static Observe Observe => new Observe();
        /// <summary>
        /// Racine pour les expressions de substitution.
        /// </summary>
        public static Substitute Substitute => new Substitute();
    }
}
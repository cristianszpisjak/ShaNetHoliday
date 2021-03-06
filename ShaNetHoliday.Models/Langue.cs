﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaNetHoliday.Models
{
    /// <summary>
    /// Langues.
    /// </summary>
    /// <remarks>https://fr.wikipedia.org/wiki/Liste_des_codes_ISO_639-1</remarks>
    public enum Langue
    {
        /// <summary>
        /// French.
        /// </summary>
        [Description( "French" )] FR,

        /// <summary>
        /// English.
        /// </summary>
        [Description( "English" )] EN,

        /// <summary>
        /// Belarusian.
        /// </summary>
        [Description( "Belarusian" )] BE,

        /// <summary>
        /// Bulgarian.
        /// </summary>
        [Description( "Bulgarian" )] BG,

        /// <summary>
        /// Bosnian.
        /// </summary>
        [Description( "Bosnian" )] BS,

        /// <summary>
        /// Catalan.
        /// </summary>
        [Description( "Catalan" )] CA,

        /// <summary>
        /// Czech.
        /// </summary>
        [Description( "Czech" )] CZ,

        /// <summary>
        /// Greek.
        /// </summary>
        [Description( "Greek" )] EL,

        /// <summary>
        /// Spanish.
        /// </summary>
        [Description( "Spanish" )] ES,

        /// <summary>
        /// Estonian.
        /// </summary>
        [Description( "Estonian" )] ET,

        /// <summary>
        /// Danish.
        /// </summary>
        [Description( "Danish" )] DA,

        /// <summary>
        /// German.
        /// </summary>
        [Description( "German" )] DE,

        /// <summary>
        /// German - Austria.
        /// </summary>
        [Description( "German - Austria" )] DE_AT,

        /// <summary>
        /// Finnish.
        /// </summary>
        [Description( "Finnish" )] FI,

        /// <summary>
        /// Croatian.
        /// </summary>
        [Description( "Croatian" )] HR,

        /// <summary>
        /// Hungarian.
        /// </summary>
        [Description( "Hungarian" )] HU,

        /// <summary>
        /// Icelandic.
        /// </summary>
        [Description( "Icelandic" )] IS,

        /// <summary>
        /// Italian.
        /// </summary>
        [Description( "Italian" )] IT,

        /// <summary>
        /// Kalaallisut
        /// </summary>
        [Description( "Kalaallisut" )] KL,

        /// <summary>
        /// Lithuanian.
        /// </summary>
        [Description( "Lithuanian" )] LT,

        /// <summary>
        /// Latvian.
        /// </summary>
        [Description( "Latvian" )] LV,

        /// <summary>
        /// Macedonian.
        /// </summary>
        [Description( "Macedonian" )] MK,

        /// <summary>
        /// Maltese.
        /// </summary>
        [Description( "Maltese" )] MT,

        /// <summary>
        /// Dutch.
        /// </summary>
        [Description( "Dutch" )] NL,

        /// <summary>
        /// Norwegian.
        /// </summary>
        [Description( "Norwegian" )] NO,

        /// <summary>
        /// Polish.
        /// </summary>
        [Description( "Polish" )] PL,

        /// <summary>
        /// Portuguese.
        /// </summary>
        [Description( "Portuguese" )] PT,

        /// <summary>
        /// Romanian.
        /// </summary>
        [Description( "Romanian" )] RO,

        /// <summary>
        /// Russian.
        /// </summary>
        [Description( "Russian" )] RU,

        /// <summary>
        /// Slovak.
        /// </summary>
        [Description( "Slovak" )] SK,

        /// <summary>
        /// Slovenian.
        /// </summary>
        [Description( "Slovenian" )] SL,

        /// <summary>
        /// Albanian.
        /// </summary>
        [Description( "Albanian" )] SQ,

        /// <summary>
        /// Serbian.
        /// </summary>
        [Description( "Serbian" )] SR,

        /// <summary>
        /// Swedish.
        /// </summary>
        [Description( "Swedish" )] SV,

        /// <summary>
        /// Ukrainian.
        /// </summary>
        [Description( "Ukrainian" )] UK,

        /// <summary>
        /// Chinese.
        /// </summary>
        [Description( "Chinese" )] ZH,

        /// <summary>
        /// Armenian.
        /// </summary>
        [Description( "Armenian" )] HY,

        /// <summary>
        /// Papiamento.
        /// </summary>
        [Description( "Papiamento" )] PAP,

        /// <summary>
        /// Azerbaijani.
        /// </summary>
        [Description( "Azerbaijani" )] AZ,

        /// <summary>
        /// Arabic.
        /// </summary>
        [Description( "Arabic" )] AR
    }
}

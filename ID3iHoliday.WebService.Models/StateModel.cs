﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iD3iHoliday.WebService.Models
{
    public class StateModel : GeographicElementModel
    {
        public List<RegionModel> Regions { get; set; }
    }
}

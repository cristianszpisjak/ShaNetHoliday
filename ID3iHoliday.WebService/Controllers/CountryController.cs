﻿using iD3iHoliday.Engine.Standard;
using iD3iHoliday.Models;
using iD3iHoliday.WebService.Divers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace iD3iHoliday.WebService.Controllers
{
    [RoutePrefix( "Countries" )]
    public class CountryController : ApiController
    {
        [HttpGet, Route( "" )]
        public IHttpActionResult Get()
        {
            return Ok( HolidaySystem.Instance.CountriesAvailable.Select( x => x.Transform() ).ToList() );
        }

        [HttpGet, Route( "{code}" )]
        public IHttpActionResult Get( string code )
        {
            var result = HolidaySystem.Instance.CountriesAvailable.FirstOrDefault( x => x.Code == code );
            return result == null ? NotFound() : (IHttpActionResult)Ok( result.Transform() );
        }

        [HttpGet]
        [Route( "{code}/Days" )]
        public IHttpActionResult Get0( string code, int year, RuleType rule = RuleType.All, Calendar calendar = Calendar.All )
        {
            var result = HolidaySystem.Instance.All( year, code, rule, calendar );
            return result == null ? NotFound() : (IHttpActionResult)Ok( result.Transform() );
        }

        [HttpGet]
        [Route( "{code}/States" )]
        public IHttpActionResult Get1( string code )
        {
            var result = HolidaySystem.Instance.CountriesAvailable.FirstOrDefault( x => x.Code == code )?.States;
            return result == null ? NotFound() : (IHttpActionResult)Ok( result.Select( x => x.Transform() ).ToList() );
        }
    }
}

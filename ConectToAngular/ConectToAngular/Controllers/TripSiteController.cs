﻿using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace ConectToAngular.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TripSiteController : ApiController
    {
       
        // GET: api/Trip
        
        [HttpGet]
        //[Route("TripSite")]
        public List<Entities.TripSite> Get()
        {

            return TripSiteBL.GetAll();



        }

        [HttpGet]
        //[Route("api/findtrip/{code}")]
        // GET: api/Trip/5
        public Entities.TripSite Get(int code)
        {
            return TripSiteBL.SearchSite(code);

            //return DB.lstTrip.Where(item => { item.TripCode == id });

        }



        //// POST: api/Trip
        [HttpPost]
        ////עדכון
        public int Post([FromBody] TripSite tripSite)
        {
           return TripSiteBL.AddSite(tripSite);
        }

        //// PUT: api/Trip/5
        [HttpPut]
     
        public int Put([FromBody]TripSite t)
        {
           return TripSiteBL.UpdateSite( t);
        }
        //[HttpPut]
        //public void Put([FromBody] Trip t)
        //{
        //    //int id = DB.lstTrip.Count;
        //    //Trip t = new Trip() { TripCode = ++id, NumMishtatfim = numms, TripName = namet, TripDate = DateTime.Today };
        //    DB.lstTrip.Add(t);
        //}



        //// DELETE: api/Trip/5
        [HttpDelete]
        //מוחקת
        public int Delete([FromBody]int id)
        {
          return  TripSiteBL.DeleteTrip(id);
       
        }

  
    }
}

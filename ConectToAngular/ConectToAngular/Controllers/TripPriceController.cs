using BL;
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
    public class TripPriceController : ApiController
    {

        // GET: api/Trip
        [HttpGet]
        public List<Entities.TripPrice> GetAllTripPrice()
        {

            return TripPricBL.GetAllTripPrice();



        }

        [HttpGet]
        // GET: api/Trip/5
        public Entities.TripPrice GetTripPrice(int TripPriceid)
        {
            return BL.TripPricBL.GetTripPrice(TripPriceid);

            //return DB.lstTrip.Where(item => { item.TripCode == id });

        }



        //// POST: api/Trip
        [HttpPost]
        ////עדכון
        public int Post([FromBody] TripPrice TripPrice)
        {
           return TripPricBL.AddTripPrice(TripPrice);
        }

        //// PUT: api/Trip/5
        [HttpPut]

        public int Put([FromBody] TripPrice t)
        {
          return  TripPricBL.UpdateTripPrice( t);
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
        public int Delete([FromBody] int id)
        {
          return  TripPricBL.DeleteTripPric(id);

        }


    }
}

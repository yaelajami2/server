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
    //[RoutePrefix("RequestTrip")]
    public class RequestTripController : ApiController
    {

        // GET: api/Trip
        [HttpGet]
        //List<Entities.RequestTrip>
        public List<Entities.RequestTrip> GetAllRequestTrip()
        {
            return RequestTripBLL.GetAll(); 



        }

        [HttpGet]
  
        // GET: api/Trip/5
        public Entities.RequestTrip GetRequestTrip(int CodeRequest)
        {
            return BL.RequestTripBLL.FindRequest(CodeRequest);

            //return DB.lstTrip.Where(item => { item.TripCode == id });

        }



        //// POST: api/Trip
        [HttpPost]
        ////עדכון
        [Route("api/postRequest")]
        public int Post([FromBody] RequestTrip requesttripe)
        {
          return  RequestTripBLL.AddRequestTrip(requesttripe);
        }

        //// PUT: api/Trip/5
        [HttpPut]

        public int Put([FromBody] int id, [FromBody]  int count)
        {
          return  RequestTripBLL.UpdateRequestTrip(id,count);
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
          return  RequestTripBLL.DeleteRequestTrip(id);

        }


    }
}

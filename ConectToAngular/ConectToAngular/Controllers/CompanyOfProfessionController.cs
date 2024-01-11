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
    public class CompanyOfProfessionController : ApiController
    {

        // GET: api/Trip
        [HttpGet]
        public List<Entities.CompanyOfProfession> GetAllCompanyOfProfession()
        {

            return CompanyOfProfessionBL.GetAllCompanyOfProfession();



        }

        [HttpGet]
        // GET: api/Trip/5
        public Entities.CompanyOfProfession GetCompanyOfProfession(int CompanyOfProfessionid)
        {
            return BL.CompanyOfProfessionBL.GetCompanyOfProfession(CompanyOfProfessionid);

            //return DB.lstTrip.Where(item => { item.TripCode == id });

        }



        //// POST: api/Trip
        [HttpPost]
        ////עדכון
        public int Post([FromBody] CompanyOfProfession CompanyOfProfessione)
        {
          return  CompanyOfProfessionBL.AddCompanyOfProfession(CompanyOfProfessione);
        }

        //// PUT: api/Trip/5
        [HttpPut]

        public int Put( [FromBody] CompanyOfProfession CompanyOfProfession)
        {
          return  CompanyOfProfessionBL.UpdateCompanyOfProfession(CompanyOfProfession);
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
        return    CompanyOfProfessionBL.DeleteCompanyOfProfession(id);

        }


    }
}

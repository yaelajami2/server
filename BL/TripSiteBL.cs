using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using GoogleApi;

namespace BL
{
  public  class TripSiteBL
    {

        public static List<TripSite> FilterTripSite(string Season, string Audience, string KindTrip,int timetravel)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {
                    List<TripSite>l= ctx.TripSite.Where(t => (t.Audience.IndexOf(Audience)!=-1 || KindTrip == "")
                    && t.KindTrip.IndexOf(KindTrip) != -1 || KindTrip ==""
                    &&(t.Season.IndexOf(Season) != -1 || Season == "")).ToList();
                    return l;
                }
            }
            catch
            {
                return null;

            }

        }
        public static List<Entities.TripSite> GetAll()
        
        {
            try
            {
                using (Database6 ctx = new Database6())
                {
                    return ctx.TripSite.ToList();
                }
            }
            catch
            {
                return null;
            }
        }
        //לא מחזיר ערך באת נפילה
        public static IEnumerable<Entities.TripSite> FindTrip(RequestTrip request)
        {
        
                using (Database6 ctx = new Database6())
                {
                TripSite[] a = ctx.TripSite.ToArray();
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i].Area == request.TripSite.Area
                        && request.TripSite.Season != null 
                        && a[i].Audience != null
                        && request.TripSite.Audience != null 
                        && a[i].Audience.ToString().Contains(request.TripSite.Audience.ToString()) == true 
                        && a[i].Season.ToString().Contains(request.TripSite.Season.ToString()) == true)
                        {
                            yield return a[i];

                        }

                    }
                }    
        }
        public static int UpdateSite( TripSite t)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {
              

                //var s = ctx.TripSite.Where(a =>a.Season.Where(d =>d==request.Season }) && a.Audience.Where(d => { if (d == request.Audience) return true; else return false; })).ToList();

                ctx.TripSite.Attach(t);
                ctx.Entry(t).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();


                    return 1;
                //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
                }
                }
            catch
            {
                return -1;
            }
      

        }
        public static TripSite SearchSite(int code)
        {
            try {
                using (Database6 ctx = new Database6())
                {

                    return ctx.TripSite.First(i => i.Code == code); }
                //var s = ctx.TripSite.Where(a =>a.Season.Where(d =>d==request.Season }) && a.Audience.Where(d => { if (d == request.Audience) return true; else return false; })).ToList();

                //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
            }
          
                catch
                {   return null;

                }
         
        }
        public static int AddSite(TripSite Trip)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {

                ctx.TripSite.Add(Trip);
                ctx.SaveChanges();


                //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
                }
                return 1;
            }
            catch
            {
           return -1;
            }
          
        
        }
        public static  int DeleteTrip(int id)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {

                    var t = (TripSite)ctx.TripSite.Single(i => (id == i.Code));
                ctx.TripSite.Remove((TripSite)t);

                ctx.SaveChanges();
                //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
                }
                return 1;
            }
            catch
            {
                return -1;
            }
       
        }
    }
}

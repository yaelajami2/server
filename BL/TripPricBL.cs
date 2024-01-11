using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TripPricBL
    {
        public static int DeleteRequestTrip(int code)
        {
            try
            {  
                using (Database6 ctx = new Database6())
            {
                DAL.RequestTripDAL.Delete(ctx.RequestTrip.Single(i => i.CodeRequest == code));



            }
                return 1;

            }
            catch
            {
                return -1;
            }
         

        }
        public static List<Entities.TripPrice> GetAllTripPrice()
        {
            try
            {   using (Database6 ctx = new Database6())
            {
                return ctx.TripPrice.ToList();


            }

            }
            catch
            {
                return null;
            }
         
        }
        public static TripPrice GetTripPrice(int id)
        {

            try
            {
                      using (Database6 ctx = new Database6())
            {
                var a = ctx.TripPrice.ToList().Where(i => i.CodeTravel == id);

                //var s = ctx.TripSite.Where(a =>a.Season.Where(d =>d==request.Season }) && a.Audience.Where(d => { if (d == request.Audience) return true; else return false; })).ToList();



                return (TripPrice)a;




                //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
            }

            }
            catch
            {
                return null;
            }
            //request.Season.HasFlag(a[i].Season) && 
    


        }
        public static int UpdateTripPrice( TripPrice t)
        {

            try
            {
                  using (Database6 ctx = new Database6())
            {
              

                //var s = ctx.TripSite.Where(a =>a.Season.Where(d =>d==request.Season }) && a.Audience.Where(d => { if (d == request.Audience) return true; else return false; })).ToList();
                ctx.TripPrice.Attach(t);
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
        //public static TripSite SearchSite(string name)
        //{
        //    using (Database6 ctx = new Database6())
        //    {
        //        TripSite[] a = ctx.TripSite.ToArray();

        //        //var s = ctx.TripSite.Where(a =>a.Season.Where(d =>d==request.Season }) && a.Audience.Where(d => { if (d == request.Audience) return true; else return false; })).ToList();
        //        for (int i = 0; i < a.Length; i++)
        //        {
        //            if (a[i].SiteName == name)
        //            {
        //                return a[i];
        //                break;

        //            }

        //        }



        //        //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
        //    }
        //    return null;
        //}
        public static int AddTripPrice(TripPrice u)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {

                    ctx.TripPrice.Add(u);
                    ctx.SaveChanges();


                    //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
                }
                return 1;
            }
            catch {
                return -1;
            }

        }
        public static int DeleteTripPric(int id)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {

                var t = ctx.TripPrice.Where(i => i.CodeTravel == id);
                ctx.TripPrice.Remove((TripPrice)t);

                ctx.SaveChanges();
                //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
                }
                return 1;
            }
            catch
            {
                return 1;
            }
         
        }
    }
}

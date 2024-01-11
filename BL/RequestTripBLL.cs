using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RequestTripBLL
    {
        public static int DeleteRequestTrip(int code)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {
                    RequestTrip boltLoad = (RequestTrip)ctx.RequestTrip.Single(i=>(code==i.CodeRequest ));

                    ctx.RequestTrip.Remove(boltLoad);
                    List<RequestTrip> requestTripall = ctx.RequestTrip.Where(i => i.group == boltLoad.group).ToList();

                    foreach (RequestTrip item in requestTripall)
                    {

                        UpdateRequestTrip(item.CodeRequest, item.ThinkNumberOfTravelers+boltLoad.NumberOfTravelers);
                            //UpdateNumOfTraveles(item.CodeRequest, item.NumberOfTravelers +Tripnum);
                        
                    };
                    //ctx.RequestTrip.(i => i.CodeRequest == code);
                    ctx.SaveChanges();

                    

                    ctx.RequestTrip.Remove(boltLoad);
                    //ctx.RequestTrip.(i => i.CodeRequest == code);
                    ctx.SaveChanges();


                }
                return 1;
            }
            catch
            {
                return -1;

            }


        }
        public static List< Entities.RequestTrip> GetAll()
        {

            try
            {


                using (Database6 ctx = new Database6())
                {
                    ctx.Configuration.ProxyCreationEnabled = false;
                    //group ללא כפולים
                    return ctx.RequestTrip.ToList();
                }

            }

            catch (Exception e)
            {
                return null;
            }
        }
        public static Entities.RequestTrip FindRequest(int request)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {
                    var a = ctx.RequestTrip.ToList().Where(i => i.CodeRequest == request);

                    //var s = ctx.TripSite.Where(a =>a.Season.Where(d =>d==request.Season }) && a.Audience.Where(d => { if (d == request.Audience) return true; else return false; })).ToList();



                    return (RequestTrip)a;




                    //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
                }

            }
            catch
            {
                return null;
            }
            //request.Season.HasFlag(a[i].Season) && 



        }
        public static int UpdateRequestTrip(int id,int count)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {

                    //ctx.RequestTrip.Attach(t);
                    //ctx.Entry(t).State = System.Data.Entity.EntityState.Modified;
                    //ctx.SaveChanges();
                    
                    RequestTrip s = ctx.RequestTrip.First(a =>a.CodeRequest==id);   
                    s.ThinkNumberOfTravelers = count;
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
        public static int UpdateNumOfTraveles(int id, int count)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {

                    //ctx.RequestTrip.Attach(t);
                    //ctx.Entry(t).State = System.Data.Entity.EntityState.Modified;
                    //ctx.SaveChanges();

                    RequestTrip s = ctx.RequestTrip.First(a => a.CodeRequest == id);
                    s.NumberOfTravelers = count;
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
        public static int UpdateRequestTripnew(RequestTrip requestTrip,int t)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {

                    //ctx.RequestTrip.Attach(t);
                    //ctx.Entry(t).State = System.Data.Entity.EntityState.Modified;
                    //ctx.SaveChanges();


                    UpdateNumOfTraveles(requestTrip.CodeRequest, requestTrip.NumberOfTravelers - t);
                    List<RequestTrip> requestTripall = ctx.RequestTrip.Where(i => i.group == requestTrip.group).ToList();
                    foreach (RequestTrip item in requestTripall)
                    {

                        UpdateRequestTrip(item.CodeRequest, item.ThinkNumberOfTravelers + t);
                
                    };
         
                    ctx.SaveChanges();
                    EmailManager.email_send(requestTrip.Maill, "עידכון מספר הנוסעים ל-"+ (requestTrip.NumberOfTravelers - t)+"בוצעה בהצלחה",  "עידכון מספר הנוסעים");
                    return 1;
                    //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
                }
            }
            catch
            {
                EmailManager.email_send(requestTrip.Maill, "עידכון מספר הנוסעים", "עידכון מספר הנוסעים נכשל אנא נסה במועד מאוחר יותר");
                return -1;
            }
        }
        public static int AddRequestTrip(RequestTrip Trip)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {
                    int now;
                    if (Trip.alltravels==0)
                    {
                    RequestTrip t = ctx.RequestTrip.Where(a => a.group == Trip.group).ToList()[0];
               
                      Trip.alltravels= t.alltravels;
                  
                     now= t.ThinkNumberOfTravelers - Trip.NumberOfTravelers; 
                    }
                    else
                    {
                        Trip.ThinkNumberOfTravelers = Trip.ThinkNumberOfTravelers - Trip.NumberOfTravelers; ;
                        now = Trip.ThinkNumberOfTravelers-Trip.NumberOfTravelers;
                    }
                    ctx.RequestTrip.Add(Trip);
                    ctx.SaveChanges();
                    int Tripnum = Trip.NumberOfTravelers;
                    EmailManager.email_send(Trip.Maill,"שלום אנו שמחים לבשר לך על הצלחתך בפתיחת טיול חדש ניתן להתעדכן על מספר המשתתפים באיזור האישי", UserBL.GetUser(Trip.UserId).FirstName+"שלום ל-");
                    if(Trip.Switch==0)
                    {  
                      foreach (RequestTrip item in ctx.RequestTrip)
                    {
                        if (item.group == Trip.group)
                        {
                            UpdateRequestTrip(item.CodeRequest, now);
                            //UpdateNumOfTraveles(item.CodeRequest, item.NumberOfTravelers +Tripnum);
                        }
                    };   

                    }
                


                    return 1;
                    //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
                }
                EmailManager.email_send(Trip.Maill,"","");
            }
            catch(Exception e)
            {
                EmailManager.email_send(Trip.Maill, "שלום לצערינו קרתה תקלה תנסה במועד מאוחר יותר", UserBL.GetUser(Trip.UserId).FirstName + "שלום ל-");
                throw new Exception("error" + e);
                return -1;
            }
        }
        //public static int DeletePassTimeTrip()
        //{
        //    try
        //    {
        //        using (Database6 ctx = new Database6())
        //        {
        //            ctx.RequestTrip.(ctx.RequestTrip.Where(t => DateTime.Now > t.StartDate));
        //            ctx.SaveChanges();
        //            return 1;
        //        }
        //    }
        //    catch
        //    {
        //        return -1;

        //    }

        //}

    }
}
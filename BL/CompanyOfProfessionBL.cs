using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CompanyOfProfessionBL
    {
        public static int DeleteRequestTrip(int code)
        {
            using (Database6 ctx = new Database6())
            {
                try
                {
                   DAL.RequestTripDAL.Delete(ctx.RequestTrip.Single(i => i.CodeRequest == code));
                    return 1;
                }
                catch
                {
                    return -1;
                }
                ;



            }

        }
        public static List<Entities.CompanyOfProfession> GetAllCompanyOfProfession()
       {
            using (Database6 ctx = new Database6())
            {
                try
                {
                   return ctx.CompanyOfProfession.ToList();
                }
                catch
                {
                    return null;
                }
                


            }
        }
        public static CompanyOfProfession GetCompanyOfProfession(int id)
        {

            try
            {
                using (Database6 ctx = new Database6())
                {
                    var a = ctx.CompanyOfProfession.ToList().Where(i => i.ProfessionId == id);

                    //var s = ctx.TripSite.Where(a =>a.Season.Where(d =>d==request.Season }) && a.Audience.Where(d => { if (d == request.Audience) return true; else return false; })).ToList();



                    return (CompanyOfProfession)a;




                    //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
                }
            }
            catch
            {
                return null;

            }
       


        }
        public static int UpdateCompanyOfProfession( CompanyOfProfession t)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {
              

                //var s = ctx.TripSite.Where(a =>a.Season.Where(d =>d==request.Season }) && a.Audience.Where(d => { if (d == request.Audience) return true; else return false; })).ToList();
                ctx.CompanyOfProfession.Attach(t);
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
        public static int AddCompanyOfProfession(CompanyOfProfession u)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {

                    ctx.CompanyOfProfession.Add(u);
                    ctx.SaveChanges();
                    return 1;


                    //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
                }
            }
            catch {
                return -1;
            }

        }
        public static int DeleteCompanyOfProfession(int id)
        {
            try
            { 
                using (Database6 ctx = new Database6())
                {

                var t = ctx.CompanyOfProfession.Where(i => i.ProfessionId == id);
                ctx.CompanyOfProfession.Remove((CompanyOfProfession)t);

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

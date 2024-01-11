using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserBL
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
        public static List<Entities.User> GetAllUser()
        {
            try
            {  
                using (Database6 ctx = new Database6())
            {
                return ctx.User.ToList();


            }

            }
            catch
            {
                return null;
            }
        
        }
        public static User GetUser(int id)
        {
            try
            {
      using (Database6 ctx = new Database6())
            {
                var a = ctx.User.FirstOrDefault(i => i.UserId == id);

                return a;

            }
            }
            catch(Exception ex)
            {
                return null;
            }
   
      


        }
        public static int UpdateUser(User t)
        {
            try
            {
                using (Database6 ctx = new Database6())
            {
                ctx.User.Attach(t);
                ctx.Entry(t).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();

            }
                return 1;

            }
            catch
            {
                return -1;
            }
      

        }
    public static User AddUser(User u)
    {
        try
        {
            using (Database6 ctx = new Database6())
            {
                List<User> listuser= ctx.User.Where(i => u.Mail == i.Mail).ToList();
                if(listuser.Count>0)
                {
                    return listuser[0];
                }
                else
                {
                    EmailManager.email_send(u.Mail,"שלום ל"+u.FirstName+" נשמח לעמוד לרשותך", "ברכותינו על הצטרפותך לאתר");
                    ctx.User.Add(u);
                    ctx.SaveChanges();
                    return u;
                }
 
                //&& a[i].ActivityTime.Contains(request.ActivityTime)request.ActivityTime!=null&&
            }
          
        }
        catch (Exception e){
            throw new Exception(e.Message);
        }

    }
        public static int DeleteUser(int id)
        {
            try
            {
          using (Database6 ctx = new Database6())
            {

                var t = ctx.User.Where(i => i.UserId == id);
                ctx.User.Remove((User)t);

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
        public static int DeleteUser(User user)
        {
            try
            {
                using (Database6 ctx = new Database6())
                {

                    var t = ctx.User.Remove(user);

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

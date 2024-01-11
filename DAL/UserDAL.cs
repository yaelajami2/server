using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public  class UserDAL
    {
        public IEnumerable<User> GerUserByID(int id)
        {
            using (Database6 ctx = new Database6())
            {

                foreach (User item in ctx.User)
                {
                    if (item.UserId == id)
                        yield return item;
                }
            }
        }

        public int PutPhone(User u,string tel)
        {
            using (Database6 ctx = new Database6())
            {
                foreach (User item in ctx.User)
                {
                    if (u.UserId == item.UserId)
                    {
                        item.Phone = tel;
                        ctx.SaveChanges();
                        return 1;
                    }                   
                }
                return -1;
            }
        }

        public int PutMail(User u, string mail)
        {
            using (Database6 ctx = new Database6())
            {
                foreach (User item in ctx.User)
                {
                    if (u.UserId == item.UserId)
                    {
                        item.Mail = mail;
                        ctx.SaveChanges();
                        return 1;
                    }
                }
                return -1;
            }
        }

        public void PostUser(User u)
        {
            using (Database6 ctx = new Database6())
            {
                ctx.User.Add(u);
                ctx.SaveChanges();
           
            }
        }

    }
}

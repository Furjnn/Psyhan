using Dataaccess;
using Dataaccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserRepo
    {
        public int CreateUser(User newUser)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Users.Add(newUser);
                    context.SaveChanges();
                    return newUser.Id; 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Kullanıcı oluşturulurken bir hata oluştu.", ex);
            }
        }


        public User CheckLogin(string username, string password)
        {
            using (var context = new ApplicationDbContext()) 
            {
                return context.Users
                    .FirstOrDefault(u => u.UserName == username && u.Password == password);
            }
        }


    }
}

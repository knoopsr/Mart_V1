using Mart_V1.Data;
using Mart_V1.Data.Models.UserProfiles;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;



namespace Mart_V1.Services.UserProfiles
{

    public class UserServices
    {
        private IDbContextFactory<SQLDbContext> _dbContextFactory;
        public UserServices(IDbContextFactory<SQLDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddUser(Users users)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
           
                context.Users.Add(users);
                context.SaveChanges();

            }
        }

        public Users GetUserByUserName(string userName)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var user = context.Users.SingleOrDefault(x => x.UserName == userName);
                return user;
            }
        }

        public void UpdateUserByUserId(string UserId, string password)
        {
            var customer = GetUserByUserName(UserId);
            if (customer == null)
            {
                throw new Exception("Customer does not exist. Cannot update");
            }
            customer.Password = password;
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Update(customer);
                context.SaveChanges();
            }

        }

        public void LoginUser (string Username, string Password)
        {

        }






    }
}

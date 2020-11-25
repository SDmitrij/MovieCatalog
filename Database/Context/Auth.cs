using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.Database.Context.Base;
using MovieCatalog.Models;

namespace MovieCatalog.Database.Context
{
    public class Auth : IdentityDbContext<User>, IContext
    {
        public Auth(DbContextOptions<Auth> options) : base(options)
        {
        }
    }
}

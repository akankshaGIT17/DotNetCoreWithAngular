using AngularWithCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularWithCore.Persistence
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options): base (options)
        {
            
        }
     public  DbSet<Make> Makes{get;set;}
        
    }
}
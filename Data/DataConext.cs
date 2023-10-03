using System.Reflection.Metadata;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;
public class DataConext: DbContext
{
   public DataConext(DbContextOptions options ): base(options)
   {

   }

   public DbSet<AppUser> Users {get; set;}

}
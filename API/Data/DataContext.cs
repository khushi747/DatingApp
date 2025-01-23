using API.Entities; 
using Microsoft.EntityFrameworkCore;
namespace API.Data;

// public class DataContext :DbContext
// {
//         public DataContext(DbContextOptions options) : base(options){ }
// }
// above code can be shortened and written like below-
// public class DataContext(DbContextOptions options):DbContext(options){ }

public class DataContext(DbContextOptions options):DbContext(options){
    public DbSet<AppUser> Users {get; set;}
    //DbSet is a class provided by EF Core that allows you to interact with a specific table in the database.
    //The T inside DbSet<T> represents the type of entities that this DbSet will manage. In this case, T is AppUser, which is a class representing users in your application.
    //It essentially provides an in-memory collection that maps to the AppUser table in the database. 
    //So when you declare a DbSet<AppUser>, you're telling EF Core: "This DbSet represents the collection of AppUser entities, and EF Core will map it to the corresponding table in the database".
}